---
description: 'Узнайте подробнее о: Создание и использование компонентов в Visual Basic'
title: Создание и использование компонентов
ms.date: 07/20/2015
helpviewer_keywords:
- components [Visual Basic]
ms.assetid: ee6a4156-73f7-4e9b-8e01-c74c4798b65c
ms.openlocfilehash: f59b4774556d95dcbc1befb16409d68a51c50535
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99666593"
---
# <a name="creating-and-using-components-in-visual-basic"></a>Создание и использование компонентов в Visual Basic

*Компонент* — это класс, который реализует интерфейс <xref:System.ComponentModel.IComponent?displayProperty=nameWithType> или прямо либо косвенно наследуется из класса, реализующего <xref:System.ComponentModel.IComponent>. Компонент .NET является объектом, который можно использовать повторно, способным взаимодействовать с другими объектами, предоставляющим контроль над внешними ресурсами и поддержку во время разработки.  
  
 Важной особенностью компонентов является то, что они поддерживают проектирование, то есть класс, являющийся компонентом, может использоваться в интегрированной среде разработки Visual Studio. Компонент можно добавить на панель элементов, перетащить в форму, кроме того, с ним можно выполнять различные действия в области конструктора. Базовая поддержка режима разработки компонентами встроена в .NET. Разработчику компонентов не нужно прикладывать дополнительные усилия, чтобы воспользоваться базовыми функциями во время разработки.  
  
 *Элемент управления* похож на компонент, в том смысле, что оба поддерживают проектирование. Тем не менее элемент управления предоставляет пользовательский интерфейс, а компонент — нет. Элемент управления должен быть производным от одного из базовых классов элементов управления: <xref:System.Windows.Forms.Control> или <xref:System.Web.UI.Control>.  
  
## <a name="when-to-create-a-component"></a>Когда требуется создание компонента  

 Если ваш класс будет использоваться в области конструктора (например, конструктора Windows Forms или веб-форм), но у него отсутствует интерфейс пользователя, он должен быть компонентом и реализовывать интерфейс <xref:System.ComponentModel.IComponent> или быть производным от класса, который непосредственно или косвенно реализует <xref:System.ComponentModel.IComponent>.  
  
 Классы <xref:System.ComponentModel.Component> и <xref:System.ComponentModel.MarshalByValueComponent> являются базовыми реализациями интерфейса <xref:System.ComponentModel.IComponent>. Основное различие между этими классами состоит в том, что класс <xref:System.ComponentModel.Component> маршалируется по ссылке, в класс <xref:System.ComponentModel.IComponent> — по значению. Ниже приведены общие указания по реализации.  
  
- Если для компонента необходимо выполнить маршалинг по ссылке, он должен быть производным от <xref:System.ComponentModel.Component>.  
  
- Если для компонента необходимо выполнить маршалинг по значению, он должен быть производным от <xref:System.ComponentModel.MarshalByValueComponent>.  
  
- Если компонент не может быть производным от одной из базовых реализаций из-за одиночного наследования, реализуйте <xref:System.ComponentModel.IComponent>.  
  
## <a name="component-classes"></a>Классы компонентов  

 Пространство имен <xref:System.ComponentModel> предоставляет классы, используемые для реализации поведения компонентов и элементов управления во время разработки и выполнения. Это пространство имен содержит базовые классы и интерфейсы для реализации атрибутов и преобразователей типов, привязки к источникам данных и лицензирования компонентов.  
  
 Ниже перечислены основные классы компонентов.  
  
- <xref:System.ComponentModel.Component>. Базовая реализация для интерфейса <xref:System.ComponentModel.IComponent>. Этот класс обеспечивает совместное использование объектов несколькими приложениями.  
  
- <xref:System.ComponentModel.MarshalByValueComponent>. Базовая реализация для интерфейса <xref:System.ComponentModel.IComponent>.  
  
- <xref:System.ComponentModel.Container>. Базовая реализация для интерфейса <xref:System.ComponentModel.IContainer>. Этот класс инкапсулирует нуль или более компонентов.  
  
 Ниже приведены некоторые классы, используемые для лицензирования компонентов.  
  
- <xref:System.ComponentModel.License>. Абстрактный базовый класс для всех лицензий. Лицензия предоставляется конкретному экземпляру компонента.  
  
- <xref:System.ComponentModel.LicenseManager>. Предоставляет свойства и методы для добавления лицензии в компонент и для управления поставщиком <xref:System.ComponentModel.LicenseProvider>.  
  
- <xref:System.ComponentModel.LicenseProvider>. Абстрактный базовый класс для реализации поставщика лицензий.  
  
- <xref:System.ComponentModel.LicenseProviderAttribute>. Указывает класс <xref:System.ComponentModel.LicenseProvider> для использования с каким-либо классом.  
  
 Ниже приведены классы, которые обычно используются для описания и постоянного хранения компонентов.  
  
- <xref:System.ComponentModel.TypeDescriptor>. Предоставляет сведения о характеристиках компонента, таких как его атрибуты, свойства и события.  
  
- <xref:System.ComponentModel.EventDescriptor>. Предоставляет сведения о событии.  
  
- <xref:System.ComponentModel.PropertyDescriptor>. Предоставляет сведения о свойстве.  
  
## <a name="related-sections"></a>Связанные разделы  

 [Разрешение вопросов, связанных с созданием элементов управления и компонентов](/dotnet/desktop/winforms/controls/troubleshooting-control-and-component-authoring)  
 Способы решения распространенных проблем.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Доступ к поддержке во время разработки в Windows Forms](/dotnet/desktop/winforms/controls/developing-windows-forms-controls-at-design-time)
