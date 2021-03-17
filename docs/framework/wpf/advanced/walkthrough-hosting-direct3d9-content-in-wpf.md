---
title: Пошаговое руководство. Размещение содержимого Direct3D9 в WPF
ms.date: 03/30/2017
helpviewer_keywords:
- Direct3D9 [WPF interoperability], hosting Direct3D9 content
- WPF [WPF], hosting Direct3D9 content
ms.assetid: 60983736-0ab5-42cc-8b16-e9fbde261a43
ms.openlocfilehash: 07cfa5bed6e5af131a60a303f0702f18413043e8
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59320239"
---
# <a name="walkthrough-hosting-direct3d9-content-in-wpf"></a>Пошаговое руководство. Размещение содержимого Direct3D9 в WPF
В этом пошаговом руководстве показано, как размещение содержимого Direct3D9 в приложении Windows Presentation Foundation (WPF).  
  
 В руководстве выполняются следующие задачи:  
  
-   Создание проекта WPF для размещения содержимого Direct3D9.  
  
-   Импорт содержимого Direct3D9.  
  
-   Отображение содержимого Direct3D9 с помощью <xref:System.Windows.Interop.D3DImage> класса.  
  
 Когда вы закончите, будет известно о размещении содержимого Direct3D9 в WPF-приложение.  
  
## <a name="prerequisites"></a>Предварительные требования  
 Ниже приведены компоненты, необходимые для выполнения данного пошагового руководства.  
  
-   Visual Studio.  
  
-   DirectX SDK, 9 или более поздней версии.  
  
-   Библиотеку DLL, содержащую содержимого Direct3D9 в WPF-совместимом формате. Дополнительные сведения см. в разделе [взаимодействие WPF и Direct3D9](wpf-and-direct3d9-interoperation.md) и [Пошаговое руководство: Создание содержимого Direct3D9 для размещения в WPF](walkthrough-creating-direct3d9-content-for-hosting-in-wpf.md).  
  
## <a name="creating-the-wpf-project"></a>Создание проекта WPF  
 Первым шагом является создание проекта приложения WPF.  
  
#### <a name="to-create-the-wpf-project"></a>Создание проекта WPF  
  
-   Создание нового проекта приложения WPF в Visual C# с именем `D3DHost`. Дополнительные сведения см. в разделе [Пошаговое руководство: Создание первого классического приложения WPF](../getting-started/walkthrough-my-first-wpf-desktop-application.md).  
  
     Файл MainWindow.xaml откроется в [!INCLUDE[wpfdesigner_current_short](../../../../includes/wpfdesigner-current-short-md.md)].  
  
## <a name="importing-the-direct3d9-content"></a>Импорт содержимого Direct3D9  
 Импорт содержимого Direct3D9 из неуправляемой библиотеки DLL с помощью `DllImport` атрибута.  
  
#### <a name="to-import-direct3d9-content"></a>Для импорта содержимого Direct3D9  
  
1. Откройте файл MainWindow.xaml.cs в редакторе кода.  
  
2. Замените автоматически созданный код следующим кодом.  
  
     [!code-csharp[System.Windows.Interop.D3DImage#1](~/samples/snippets/csharp/VS_Snippets_Wpf/System.Windows.Interop.D3DImage/CS/window1.xaml.cs#1)]  
  
## <a name="hosting-the-direct3d9-content"></a>Размещение содержимого Direct3D9  
 Наконец, используйте <xref:System.Windows.Interop.D3DImage> класса для размещения содержимого Direct3D9.  
  
#### <a name="to-host-the-direct3d9-content"></a>Для размещения содержимого Direct3D9  
  
1. В файле MainWindow.xaml замените автоматически созданный XAML следующий XAML.  
  
     [!code-xaml[System.Windows.Interop.D3DImage#10](~/samples/snippets/csharp/VS_Snippets_Wpf/System.Windows.Interop.D3DImage/CS/window1.xaml#10)]  
  
2. Выполните построение проекта.  
  
3. Скопируйте библиотеку DLL, содержащую содержимого Direct3D9 в папку bin/Debug.  
  
4. Нажмите клавишу F5, чтобы запустить проект.  
  
     Содержимое Direct3D9 в WPF-приложении.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Interop.D3DImage>
- [Вопросы производительности, связанные с взаимодействием Direct3D9 и WPF](performance-considerations-for-direct3d9-and-wpf-interoperability.md)
