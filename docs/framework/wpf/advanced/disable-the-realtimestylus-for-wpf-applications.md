---
title: Отключение объекта RealTimeStylus для WPF-приложений
ms.date: 03/30/2017
ms.assetid: e0525309-5ede-4782-837d-dbf6e5554859
ms.openlocfilehash: e44b71ac5af64ab3a6cb008db71e5a8881592e91
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59124687"
---
# <a name="disable-the-realtimestylus-for-wpf-applications"></a>Отключение объекта RealTimeStylus для WPF-приложений
Windows Presentation Foundation (WPF) обеспечивает встроенную поддержку для обработки сенсорного ввода Windows 7. Поддержка проходит по в режиме реального времени платформой планшетного пера как <xref:System.Windows.UIElement.OnStylusDown%2A>, <xref:System.Windows.UIElement.OnStylusUp%2A>, и <xref:System.Windows.UIElement.OnStylusMove%2A> события. Windows 7 также предоставляет мультисенсорного ввода, как окно сообщения Win32 WM_TOUCH. Эти два API являются взаимно исключают друг друга на одном HWND. Включение сенсорного ввода с помощью этой платформы tablet (по умолчанию для приложений WPF) отключает сообщения WM_TOUCH. Таким образом Чтобы использовать WM_TOUCH для получения сенсорных сообщений из окна WPF, необходимо отключить встроенную поддержку пера в WPF. Это применимо в сценарии, такие как окно WPF, компонент, который использует WM_TOUCH.  
  
 Чтобы отключить прослушивание ввод с помощью пера WPF, удалите всю поддержку планшета, добавленные в окне WPF.  
  
## <a name="example"></a>Пример  
 В следующем примере кода показан способ удаления поддержки платформы планшета по умолчанию с помощью отражения.  
  
```  
public static void DisableWPFTabletSupport()  
{  
    // Get a collection of the tablet devices for this window.    
    TabletDeviceCollection devices = System.Windows.Input.Tablet.TabletDevices;  
  
    if (devices.Count > 0)  
    {     
        // Get the Type of InputManager.  
        Type inputManagerType = typeof(System.Windows.Input.InputManager);  
  
        // Call the StylusLogic method on the InputManager.Current instance.  
        object stylusLogic = inputManagerType.InvokeMember("StylusLogic",  
                    BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic,  
                    null, InputManager.Current, null);  
  
        if (stylusLogic != null)  
        {  
            //  Get the type of the stylusLogic returned from the call to StylusLogic.  
            Type stylusLogicType = stylusLogic.GetType();  
  
            // Loop until there are no more devices to remove.  
            while (devices.Count > 0)  
            {  
                // Remove the first tablet device in the devices collection.  
                stylusLogicType.InvokeMember("OnTabletRemoved",  
                        BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic,  
                        null, stylusLogic, new object[] { (uint)0 });  
            }                  
        }  
  
    }  
}  
```  
  
## <a name="see-also"></a>См. также

- [Перехват ввода, осуществляемого пером](intercepting-input-from-the-stylus.md)
