---
description: Дополнительные сведения см. в статье Использование расширений действий.
title: Использование модулей действий
ms.date: 03/30/2017
ms.assetid: 500eb96a-c009-4247-b6b5-b36faffdf715
ms.openlocfilehash: d0286850bf685497d3a2471a3b4e0db4630070b1
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99755074"
---
# <a name="using-activity-extensions"></a>Использование модулей действий

Действия могут взаимодействовать с расширениями приложений рабочих процессов. Благодаря этому узел может предоставлять дополнительные возможности, которые не были явно смоделированы в рабочем процессе.  В этом разделе описывается создание расширений для подсчета количества выполнений действия.

### <a name="to-use-an-activity-extension-to-count-executions"></a>Использования расширения действия для подсчета выполнений

1. Откройте Visual Studio 2010. Выберите **создать**, **проект**. В узле **Visual C#** выберите **Рабочий процесс**.  Выберите **консольное приложение рабочего процесса** из списка шаблонов. Задайте для проекта имя `Extensions`. Чтобы создать проект, нажмите кнопку **ОК** .

2. Добавьте `using` инструкцию в файл Program.cs для пространства имен **System. Collections. Generic** .

    ```csharp
    using System.Collections.Generic;
    ```

3. В файле Program.cs создайте новый класс с именем **ексекутионкаунтекстенсион**. Следующий код создает расширение рабочего процесса, которое отслеживает идентификаторы экземпляров при вызове метода **Register** .

    ```csharp
    // This extension collects a list of workflow Ids
    public class ExecutionCountExtension
    {
        IList<Guid> instances = new List<Guid>();

        public int ExecutionCount
        {
            get
            {
                return this.instances.Count;
            }
        }

        public IEnumerable<Guid> InstanceIds
        {
            get
            {
                return this.instances;
            }
        }

        public void Register(Guid activityInstanceId)
        {
            if (!this.instances.Contains<Guid>(activityInstanceId))
            {
                instances.Add(activityInstanceId);
            }
        }
    }
    ```

4. Создайте действие, которое использует **ексекутионкаунтекстенсион**. В следующем коде определяется действие, которое получает объект **ексекутионкаунтекстенсион** из среды выполнения и вызывает его метод **Register** при выполнении действия.

    ```csharp
    // Activity that consumes an extension provided by the host. If the extension is available
    // in the context, it will invoke (in this case, registers the Id of the executing workflow)
    public class MyActivity: CodeActivity
    {
        protected override void Execute(CodeActivityContext context)
        {
            ExecutionCountExtension ext = context.GetExtension<ExecutionCountExtension>();
            if (ext != null)
            {
                ext.Register(context.WorkflowInstanceId);
            }

        }
    }
    ```

5. Реализуйте действие в методе **Main** файла Program.cs. В следующем коде содержатся методы для создания двух различных рабочих процессов, выполнения всех процессов по несколько раз и отображения полученных данных, содержащихся в расширении.

    ```csharp
    class Program
    {
        // Creates a workflow that uses the activity that consumes the extension
        static Activity CreateWorkflow1()
        {
            return new Sequence
            {
                Activities =
                {
                    new MyActivity()
                }
            };
        }

        // Creates a workflow that uses two instances of the activity that consumes the extension
        static Activity CreateWorkflow2()
        {
            return new Sequence
            {
                Activities =
                {
                    new MyActivity(),
                    new MyActivity()
                }
            };
        }

        static void Main(string[] args)
        {
            // create the extension
            ExecutionCountExtension executionCountExt = new ExecutionCountExtension();

            // configure the first invoker and execute 3 times
            WorkflowInvoker invoker = new WorkflowInvoker(CreateWorkflow1());
            invoker.Extensions.Add(executionCountExt);
            invoker.Invoke();
            invoker.Invoke();
            invoker.Invoke();

            // configure the second invoker and execute 2 times
            WorkflowInvoker invoker2 = new WorkflowInvoker(CreateWorkflow2());
            invoker2.Extensions.Add(executionCountExt);
            invoker2.Invoke();
            invoker2.Invoke();

            // show the data in the extension
            Console.WriteLine("Executed {0} times", executionCountExt.ExecutionCount);
            executionCountExt.InstanceIds.ToList().ForEach(i => Console.WriteLine("...{0}", i));
        }
    }
    ```
