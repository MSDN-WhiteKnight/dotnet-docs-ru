---
title: Практическое руководство. Фоновая загрузка файла
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- BackgroundWorker component
- background tasks
- Asynchronous Pattern
- forms [Windows Forms], multithreading
- components [Windows Forms], asynchronous
- forms [Windows Forms], background operations
- threading [Windows Forms], background operations
- background operations
ms.assetid: 9b7bc5ae-051c-4904-9720-18f6667388bd
ms.openlocfilehash: af5a607b4800635d096e83b55a5bd5a912c8538d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59128782"
---
# <a name="how-to-download-a-file-in-the-background"></a>Практическое руководство. Фоновая загрузка файла
Загрузка файла — это обычная задача, и было бы разумным запускать эту потенциально длительную операцию в отдельном потоке. С помощью компонента <xref:System.ComponentModel.BackgroundWorker> и небольшого фрагмента кода эта задача легко решается.  
  
## <a name="example"></a>Пример  
 В примере кода ниже демонстрируется использование компонента <xref:System.ComponentModel.BackgroundWorker> для загрузки XML-файла с URL-адреса. Когда пользователь щелкает **загрузить** кнопки <xref:System.Windows.Forms.Control.Click> вызовов обработчика событий <xref:System.ComponentModel.BackgroundWorker.RunWorkerAsync%2A> метод <xref:System.ComponentModel.BackgroundWorker> компонента для запуска операции загрузки. Кнопка отключается во время загрузки, а по его окончании снова становится активной. В поле <xref:System.Windows.Forms.MessageBox> выводится содержимое файла.  
  
 [!code-csharp[System.ComponentModel.BackgroundWorker.IsBusy#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker.IsBusy/CS/Form1.cs#1)]
   
  
 **Загрузка файла**  
  
 Файл скачивается в рабочем потоке компонента <xref:System.ComponentModel.BackgroundWorker>, который запускает обработчик событий <xref:System.ComponentModel.BackgroundWorker.DoWork>. Этот поток запускается, когда код вызывает метод <xref:System.ComponentModel.BackgroundWorker.RunWorkerAsync%2A>.  
  
 [!code-csharp[System.ComponentModel.BackgroundWorker.IsBusy#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker.IsBusy/CS/Form1.cs#3)]
   
  
 **Ожидание завершения работы BackgroundWorker**  
  
 Обработчик событий `downloadButton_Click` демонстрирует ожидание завершения выполнения асинхронной задачи компонентом <xref:System.ComponentModel.BackgroundWorker>.  
  
 Если нужно, чтобы приложение лишь реагировало на события и не выполняло никакой работы в основном потоке в ожидании, пока не завершится выполнение фонового потока, просто завершите работу обработчика.  
  
 Если нужно продолжить выполнение работы в основном потоке, воспользуйтесь свойством <xref:System.ComponentModel.BackgroundWorker.IsBusy%2A>, чтобы определить, по-прежнему ли выполняется поток <xref:System.ComponentModel.BackgroundWorker>. В примере индикатор выполнения обновляется в процессе загрузки. Для сохранения отклика пользовательского интерфейса обязательно вызовите метод <xref:System.Windows.Forms.Application.DoEvents%2A?displayProperty=nameWithType>.  
  
 [!code-csharp[System.ComponentModel.BackgroundWorker.IsBusy#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker.IsBusy/CS/Form1.cs#2)]
   
  
 **Вывод результата**  
  
 Метод `backgroundWorker1_RunWorkerCompleted` обрабатывает событие <xref:System.ComponentModel.BackgroundWorker.RunWorkerCompleted> и вызывается по завершении фоновой операции. Сначала этот метод проверяет свойство <xref:System.ComponentModel.AsyncCompletedEventArgs.Error%2A?displayProperty=nameWithType>. Если свойство <xref:System.ComponentModel.AsyncCompletedEventArgs.Error%2A?displayProperty=nameWithType> имеет значение `null`, то метод выводит содержимое файла. Затем он активирует кнопку загрузки, которая была отключена, когда началась загрузка, и сбрасывает индикатор выполнения.  
  
 [!code-csharp[System.ComponentModel.BackgroundWorker.IsBusy#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker.IsBusy/CS/Form1.cs#4)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System.Drawing, System.Windows.Forms и System.Xml.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="robust-programming"></a>Отказоустойчивость  
 Перед попыткой обращения к свойству <xref:System.ComponentModel.RunWorkerCompletedEventArgs.Result%2A?displayProperty=nameWithType> или любому другому объекту, который может быть изменен обработчиком событий <xref:System.ComponentModel.BackgroundWorker.DoWork>, всегда проверяйте свойство <xref:System.ComponentModel.AsyncCompletedEventArgs.Error%2A?displayProperty=nameWithType> в обработчике событий <xref:System.ComponentModel.BackgroundWorker.RunWorkerCompleted>.  
  
## <a name="see-also"></a>См. также

- <xref:System.ComponentModel.BackgroundWorker>
- [Практическое руководство. Фоновое выполнение операции](how-to-run-an-operation-in-the-background.md)
- [Практическое руководство. Реализация формы, в которой выполняется фоновая операция](how-to-implement-a-form-that-uses-a-background-operation.md)
