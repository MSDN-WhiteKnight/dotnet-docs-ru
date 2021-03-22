---
title: Практическое руководство. Создание параметров приложения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- application settings [Windows Forms], Windows Forms
- application settings [Windows Forms], creating
ms.assetid: 1e7aa347-af75-41e5-89ca-f53cab704f72
ms.openlocfilehash: 5cf109aec8b55650f43f07f5b303c6373df4efc7
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59305979"
---
# <a name="how-to-create-application-settings"></a>Практическое руководство. Создание параметров приложения
С помощью управляемого кода можно создавать параметры приложения и привязывать их к свойствам формы или ее элементов управления, чтобы эти параметры загружались и сохранялись автоматически во время выполнения.  
  
 В представленной ниже процедуре вручную создается класс-оболочка, производный от класса <xref:System.Configuration.ApplicationSettingsBase>. К этому классу добавляется открытое свойство для каждого параметра приложения, который требуется предоставить.  
  
 Эту процедуру можно также выполнить с помощью минимального объема кода в конструкторе Visual Studio.  Также см. раздел [Как Создание параметров приложения с помощью конструктора](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/wabtadw6(v=vs.100)).  
  
### <a name="to-create-new-application-settings-programmatically"></a>Создание параметров приложения программными средствами  
  
1. Добавьте в проект новый класс и переименуйте его. Для выполнения этой процедуры мы назовем этот класс `MyUserSettings`. Измените определение класса так, чтобы он стал производным от <xref:System.Configuration.ApplicationSettingsBase>.  
  
2. Определите в этом классе-оболочке свойство для каждого требуемого параметра приложения и примените его с атрибутом <xref:System.Configuration.ApplicationScopedSettingAttribute> или <xref:System.Configuration.UserScopedSettingAttribute> в зависимости от области действия параметра. Дополнительные сведения об области действия параметров см. в разделе [Общие сведения о параметрах приложения](application-settings-overview.md). На этом этапе код должен выглядеть так:  
  
     [!code-csharp[ApplicationSettings.Create#1](~/samples/snippets/csharp/VS_Snippets_Winforms/ApplicationSettings.Create/CS/MyAppSettings.cs#1)]
       
  
3. Создайте экземпляр этого класса-оболочки в приложении. Как правило, он является закрытым членом главной формы. Определив класс, нужно привязать его к свойству, в данном случае к свойству <xref:System.Windows.Forms.Form.BackColor%2A> формы. Это можно сделать в вашей форме `Load` обработчик событий.  
  
     [!code-csharp[ApplicationSettings.Create#2](~/samples/snippets/csharp/VS_Snippets_Winforms/ApplicationSettings.Create/CS/Form1.cs#2)]
       
  
4. Если вы предоставляете возможность изменения параметров во время выполнения, необходимо сохранять текущие параметры пользователя на диск при закрытии формы, иначе изменения будут потеряны.  
  
     [!code-csharp[ApplicationSettings.Create#3](~/samples/snippets/csharp/VS_Snippets_Winforms/ApplicationSettings.Create/CS/Form1.cs#3)]
       
  
     Теперь новый параметр приложения успешно создан и связан с указанным свойством.  
  
## <a name="net-framework-security"></a>Безопасность платформы .NET Framework  
 Поставщик параметров по умолчанию, <xref:System.Configuration.LocalFileSettingsProvider>, сохраняет сведения в файлах конфигурации в виде обычного текста. В результате безопасность зависит от уровня разрешений на доступ к файлу, предоставляемого операционной системой текущему пользователю. Поэтому при хранении информации в файлах конфигурации необходимо соблюдать осторожность. Например, параметры приложения часто используются для хранения строк подключений, которые указывают на хранилище данных приложения. Однако в целях безопасности в таких строках не должны содержаться пароли. Подробнее о строках подключения см. в разделе <xref:System.Configuration.SpecialSetting>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Configuration.SpecialSettingAttribute>
- <xref:System.Configuration.LocalFileSettingsProvider>
- [Общие сведения о параметрах приложений](application-settings-overview.md)
- [Практическое руководство. Проверка параметров приложения](how-to-validate-application-settings.md)
