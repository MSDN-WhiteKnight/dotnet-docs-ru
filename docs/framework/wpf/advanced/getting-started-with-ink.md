---
title: Создание объекту класса InkCanvas в приложении WPF в Visual Studio
ms.date: 08/15/2018
dev_langs:
- csharp
- vb
helpviewer_keywords:
- procedural code in lieu of XAML [WPF]
- XAML [WPF], procedural code in lieu of
- InkCanvas (WPF)
ms.assetid: 760332dd-594a-475d-865b-01659db8cab7
ms.openlocfilehash: 4309b1108b2ea96eb298ff3bb876a0f63b80dc32
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59343601"
---
# <a name="get-started-with-ink-in-wpf"></a>Начало работы с рукописными данными в WPF

Windows Presentation Foundation (WPF) есть функция рукописного ввода, которая позволяет легко внедрить рукописный ввод в приложение.

## <a name="prerequisites"></a>Предварительные требования

Чтобы использовать в следующих примерах, сначала нужно установить [Microsoft Visual Studio](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019). Полезно также знать способы написания базовых приложений WPF. Помощь по началу работы с WPF, см. в разделе [Пошаговое руководство: Создание первого классического приложения WPF](../getting-started/walkthrough-my-first-wpf-desktop-application.md).

## <a name="quick-start"></a>Быстрый запуск

Этот раздел поможет написать простое приложение WPF, сбора данных рукописного ввода.

### <a name="got-ink"></a>У вас есть рукописного ввода?

Создание приложения WPF с поддержкой рукописного ввода:

1. Запустите Visual Studio.

2. Создайте новый **приложение WPF**.

   В **новый проект** диалоговом окне разверните **установленные** > **Visual C#** или **Visual Basic**  >   **Windows Desktop** категории. Выберите **приложение WPF (.NET Framework)** шаблон приложения. Введите имя, а затем выберите **ОК**.

   Visual Studio создает проект, и *MainWindow.xaml* откроется в конструкторе.

3. Тип `<InkCanvas/>` между `<Grid>` теги.

   ![Конструктор XAML с тегом InkCanvas](./media/getting-started-with-ink/inkcanvas-xaml.png)

4. Нажмите клавишу **F5** для запуска приложения в отладчике.

5. С помощью пера или мышь, писать **Здравствуй, мир** в окне.

Вы написали рукописный эквивалент приложения на «hello world» с помощью всего 12 клавиш!

### <a name="spice-up-your-app"></a>Оживить приложения

Рассмотрим преимущества некоторых функций WPF. Замените весь код между открывающим и закрывающим \<окна > теги, используя следующую разметку:

```xaml
<Page>
  <InkCanvas Name="myInkCanvas" MouseRightButtonUp="RightMouseUpHandler">
    <InkCanvas.Background>
      <LinearGradientBrush>
        <GradientStop Color="Yellow" Offset="0.0" />
          <GradientStop Color="Blue" Offset="0.5" />
            <GradientStop Color="HotPink" Offset="1.0" />
              </LinearGradientBrush>
    </InkCanvas.Background>
  </InkCanvas>
</Page>
```

Этот XAML создает градиентный фон поверхности рукописного ввода.

![Цвета градиента на рукописный ввод поверхности в приложении WPF](./media/getting-started-with-ink/gradient-colors.png)

### <a name="add-some-code-behind-the-xaml"></a>Добавление кода программной части XAML

Хотя XAML позволяет очень легко разрабатывать пользовательский интерфейс, любой реальных приложений необходимо добавить код для обработки событий. Ниже приведен простой пример увеличения рукописный ввод в ответ на щелчок правой кнопкой мыши.

1. Задайте `MouseRightButtonUp` обработчика в вашей XAML:

   [!code-xaml[DigitalInkTopics#3](~/samples/snippets/csharp/VS_Snippets_Wpf/DigitalInkTopics/CSharp/Window2.xaml#3)]

1. В **обозревателе решений**, разверните файл MainWindow.xaml и откройте файл с выделенным кодом (MainWindow.xaml.cs или MainWindow.xaml.vb). Добавьте следующий код обработчика событий:

   [!code-csharp[DigitalInkTopics#4](~/samples/snippets/csharp/VS_Snippets_Wpf/DigitalInkTopics/CSharp/Window2.xaml.cs#4)]
   [!code-vb[DigitalInkTopics#4](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DigitalInkTopics/VisualBasic/Window2.xaml.vb#4)]

1. Запустите приложение. Добавьте рукописные и щелкните правой кнопкой мыши, с помощью мыши или эквивалента нажатие и удерживание с помощью пера.

   Отображение увеличивает каждый раз, когда щелчком правой кнопки мыши.

### <a name="use-procedural-code-instead-of-xaml"></a>Используйте процедурный код вместо XAML

От процедурного кода доступны все возможности WPF. Выполните следующие действия, чтобы создать приложение «Hello Ink World» для WPF, не использующего любого XAML.

1. Создайте новый проект консольного приложения в Visual Studio.

   В **новый проект** диалоговом окне разверните **установленные** > **Visual C#** или **Visual Basic**  >   **Windows Desktop** категории. Выберите **консольное приложение (.NET Framework)** шаблон приложения. Введите имя, а затем выберите **ОК**.

1. Вставьте следующий код в файле Program.cs или Program.vb:

   [!code-csharp[InkCanvasConsoleApp#1](~/samples/snippets/csharp/VS_Snippets_Wpf/InkCanvasConsoleApp/CSharp/Program.cs#1)]
   [!code-vb[InkCanvasConsoleApp#1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/InkCanvasConsoleApp/VisualBasic/Module1.vb#1)]

1. Добавьте ссылки на сборки PresentationCore, PresentationFramework и WindowsBase, щелкнув правой кнопкой мыши **ссылки** в **обозревателе решений** и выбрав **добавить ссылку на**.

   ![Диспетчер ссылок, показывающий PresentationCore и PresentationFramework](./media/getting-started-with-ink/references.png)

1. Постройте приложение, нажав клавишу **F5**.

## <a name="see-also"></a>См. также

- [Рукописный ввод](digital-ink.md)
- [Сбор рукописных данных](collecting-ink.md)
- [Распознавание рукописного ввода](handwriting-recognition.md)
- [Хранение рукописных данных](storing-ink.md)
