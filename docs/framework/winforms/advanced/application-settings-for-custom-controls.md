---
title: Параметры приложения для пользовательских элементов управления
ms.date: 03/30/2017
helpviewer_keywords:
- custom controls [Windows Forms], application settings
- application settings [Windows Forms], custom controls
ms.assetid: f44afb74-76cc-44f2-890a-44b7cdc211a1
ms.openlocfilehash: 69a5caef8bab45503b9f34422de8c2ba2e7f01ff
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59317302"
---
# <a name="application-settings-for-custom-controls"></a>Параметры приложения для пользовательских элементов управления
Необходимо выполнить определенные задачи, чтобы предоставить возможность сохранения параметров приложения элементы управления расположены в сторонних приложениях пользовательских элементов управления.  
  
 Большая часть документации о параметры приложения записывается в предположении, что вы создаете изолированное приложение. Тем не менее, если вы создаете элемент управления, который будет размещаться другим разработчикам в своих приложениях, необходимо выполнить ряд дополнительных действий для элемента управления для сохранения его параметры должным образом.  
  
## <a name="application-settings-and-custom-controls"></a>Параметры приложения и пользовательские элементы управления  
 Элемент управления правильно сохранял свои параметры, он должен инкапсулировать процесс, создав свой собственный выделенный приложений параметры оболочки класс, производный от <xref:System.Configuration.ApplicationSettingsBase>. Кроме того, необходимо реализовать класс основной элемент управления <xref:System.Configuration.IPersistComponentSettings>. Интерфейс содержит несколько свойств, а также два метода <xref:System.Configuration.IPersistComponentSettings.LoadComponentSettings%2A> и <xref:System.Configuration.IPersistComponentSettings.SaveComponentSettings%2A>. Если добавить элемент управления в форме с помощью **конструктор Windows Forms** в Visual Studio, Windows Forms будет вызывать <xref:System.Configuration.IPersistComponentSettings.LoadComponentSettings%2A> автоматически при инициализации элемента управления; необходимо вызвать <xref:System.Configuration.IPersistComponentSettings.SaveComponentSettings%2A> самостоятельно в `Dispose` метод вашего элемента управления.  
  
 Кроме того чтобы параметры приложения для пользовательских элементов управления для правильной работы в средах разработки, таких как Visual Studio следует реализовать следующие:  
  
1. Пользовательский класс параметров приложения с помощью конструктора, принимающего <xref:System.ComponentModel.IComponent> в качестве единственного параметра. Этот класс используется для сохранения и загрузки всех параметров приложения. При создании нового экземпляра этого класса, передайте пользовательский элемент управления с помощью конструктора.  
  
2. Создайте этот пользовательский класс параметров после создан и помещен в форму, например в форме элемент управления <xref:System.Windows.Forms.Form.Load> обработчик событий.  
  
 Инструкции по созданию пользовательского класса параметров см. в разделе [как: Создание параметров приложения](how-to-create-application-settings.md).  
  
## <a name="settings-keys-and-shared-settings"></a>Параметры ключей и общими настройками  
 Некоторые элементы управления можно использовать несколько раз в пределах той же форме. В большинстве случаев, требуется эти элементы управления, чтобы сохранить свои собственные отдельные параметры. С помощью <xref:System.Configuration.IPersistComponentSettings.SettingsKey%2A> свойство <xref:System.Configuration.IPersistComponentSettings>, можно указать уникальная строка, которая используется для однозначного определения нескольких версий элемента управления в форме.  
  
 Самый простой способ реализации <xref:System.Configuration.IPersistComponentSettings.SettingsKey%2A> заключается в использовании <xref:System.Windows.Forms.Control.Name%2A> свойство элемента управления для <xref:System.Configuration.IPersistComponentSettings.SettingsKey%2A>. При загрузке или сохранении параметры элемента управления, передается значение <xref:System.Configuration.IPersistComponentSettings.SettingsKey%2A> в <xref:System.Configuration.ApplicationSettingsBase.SettingsKey%2A> свойство <xref:System.Configuration.ApplicationSettingsBase> класса. Параметры приложения используют этот уникальный ключ для сохранения параметров пользователя в XML. В следующем примере кода как `<userSettings>` раздел может иметь для экземпляра пользовательского элемента управления с именем `CustomControl1` , сохраняет параметр в его `Text` свойство.  
  
```xml  
<userSettings>  
    <CustomControl1>  
        <setting name="Text" serializedAs="string">  
            <value>Hello, World</value>  
        </setting>  
    </CustomControl1>  
</userSettings>  
```  
  
 Все экземпляры элемента управления, который не нужно вводить значение для <xref:System.Configuration.ApplicationSettingsBase.SettingsKey%2A> будут совместно использовать те же параметры.  
  
## <a name="see-also"></a>См. также

- <xref:System.Configuration.ApplicationSettingsBase>
- <xref:System.Configuration.IPersistComponentSettings>
- [Архитектура параметров приложения](application-settings-architecture.md)
