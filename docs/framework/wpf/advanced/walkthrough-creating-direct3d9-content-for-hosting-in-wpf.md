---
title: Пошаговое руководство. Создание содержимого Direct3D9 для размещения в WPF
ms.date: 03/30/2017
dev_langs:
- cpp
helpviewer_keywords:
- WPF [WPF], creating Direct3D9 content
- Direct3D9 [WPF interoperability], creating Direct3D9 content
ms.assetid: 286e98bc-1eaa-4b5e-923d-3490a9cca5fc
ms.openlocfilehash: 160395b84ef7ca447d162ceff34752113a1d59a9
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59300272"
---
# <a name="walkthrough-creating-direct3d9-content-for-hosting-in-wpf"></a>Пошаговое руководство. Создание содержимого Direct3D9 для размещения в WPF
В этом пошаговом руководстве демонстрируется создание содержимого Direct3D9 для размещения в приложении Windows Presentation Foundation (WPF). Дополнительные сведения о размещении содержимого Direct3D9 в WPF-приложениях, см. в разделе [взаимодействие WPF и Direct3D9](wpf-and-direct3d9-interoperation.md).

 В руководстве выполняются следующие задачи:

-   Создайте проект Direct3D9.

-   Настройка проекта Direct3D9 для размещения в приложении WPF.

 Когда вы закончите, вы получите библиотеку DLL, содержащую содержимого Direct3D9 для использования в приложении WPF.

## <a name="prerequisites"></a>Предварительные требования
 Ниже приведены компоненты, необходимые для выполнения данного пошагового руководства.

-   Visual Studio 2010.

-   DirectX SDK, 9 или более поздней версии.

## <a name="creating-the-direct3d9-project"></a>Создание проекта Direct3D9
 Первый шаг — создание и настройка проекта Direct3D9.

#### <a name="to-create-the-direct3d9-project"></a>Чтобы создать проект Direct3D9

1. Создание проекта Win32 в C++ с именем `D3DContent`.

     Мастер приложений Win32 открывает и отображает экран приветствия.

2. Нажмите кнопку **Далее**.

     На экране параметров приложения.

3. В **тип приложения:** выберите **DLL** параметр.

4. Нажмите кнопку **Готово**.

     Создается проект D3DContent.

5. В обозревателе решений щелкните правой кнопкой мыши проект D3DContent и выберите **свойства**.

     **Свойств D3dcontent** откроется диалоговое окно.

6. Выберите **C/C++** узла.

7. В **Дополнительные каталоги включаемых файлов** укажите расположение с DirectX включать папку. Находится в папке по умолчанию для этой папки %ProgramFiles%\Microsoft DirectX SDK (*версии*) \Include.

8. Дважды щелкните **компоновщика** узел, чтобы развернуть его.

9. В **Дополнительные каталоги библиотек** укажите расположение папки библиотек DirectX. Находится в папке по умолчанию для этой папки %ProgramFiles%\Microsoft DirectX SDK (*версии*) \Lib\x86.

10. Выберите **ввода** узла.

11. В **Дополнительные зависимости** поле, добавьте `d3d9.lib` и `d3dx9.lib` файлы.

12. В обозревателе решений добавьте новый файл определения модуля (.def) с именем `D3DContent.def` в проект.

## <a name="creating-the-direct3d9-content"></a>Создание содержимого Direct3D9
 Чтобы получить наилучшую производительность, содержимого Direct3D9 необходимо использовать определенные параметры. Приведенный ниже показано, как создать Direct3D9 поверхности, которая имеет лучшие характеристики производительности. Дополнительные сведения см. в разделе [рекомендации по ускорению взаимодействием Direct3D9 и WPF](performance-considerations-for-direct3d9-and-wpf-interoperability.md).

#### <a name="to-create-the-direct3d9-content"></a>Создание содержимого Direct3D9

1. С помощью обозревателя решений, добавьте в проект с именем следующие три класса C++.

     `CRenderer` (с виртуальным деструктором)

     `CRendererManager`

     `CTriangleRenderer`

2. Откройте Renderer.h в редакторе кода и замените автоматически созданный код следующим кодом.

     

3. Откройте Renderer.cpp в редакторе кода и замените автоматически созданный код следующим кодом.

     

4. Откройте RendererManager.h в редакторе кода и замените автоматически созданный код следующим кодом.

     

5. Откройте RendererManager.cpp в редакторе кода и замените автоматически созданный код следующим кодом.

     

6. Откройте TriangleRenderer.h в редакторе кода и замените автоматически созданный код следующим кодом.

     

7. Откройте TriangleRenderer.cpp в редакторе кода и замените автоматически созданный код следующим кодом.

     

8. Откройте файл stdafx.h в редакторе кода и замените автоматически созданный код следующим кодом.

     

9. Откройте dllmain.cpp в редакторе кода и замените автоматически созданный код следующим кодом.

     

10. Откройте D3DContent.def в редакторе кода.

11. Замените автоматически созданный код следующим кодом.

    ```
    LIBRARY "D3DContent"

    EXPORTS

    SetSize
    SetAlpha
    SetNumDesiredSamples
    SetAdapter

    GetBackBufferNoRef
    Render
    Destroy
    ```

12. Выполните построение проекта.

## <a name="next-steps"></a>Следующие шаги

-   Размещение содержимого Direct3D9 в WPF-приложение. Дополнительные сведения см. в разделе [Пошаговое руководство: Размещение содержимого Direct3D9 в WPF](walkthrough-hosting-direct3d9-content-in-wpf.md).

## <a name="see-also"></a>См. также

- <xref:System.Windows.Interop.D3DImage>
- [Вопросы производительности, связанные с взаимодействием Direct3D9 и WPF](performance-considerations-for-direct3d9-and-wpf-interoperability.md)
- [Пошаговое руководство. Размещение содержимого Direct3D9 в WPF](walkthrough-hosting-direct3d9-content-in-wpf.md)
