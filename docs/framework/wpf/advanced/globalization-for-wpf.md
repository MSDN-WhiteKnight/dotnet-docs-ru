---
title: Глобализация для WPF
ms.date: 03/30/2017
helpviewer_keywords:
- XAML [WPF], international user interface
- XAML [WPF], globalization
- international user interface [WPF], XAML
- globalization [WPF]
ms.assetid: 4571ccfe-8a60-4f06-9b37-7ac0b1c2d10f
ms.openlocfilehash: 9a08fdeaa3517b1483af3f9958ad2db1c64648b8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59084171"
---
# <a name="globalization-for-wpf"></a>Глобализация для WPF
В этом разделе рассматриваются проблемы, которые следует иметь в виду при написании [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] приложений для мирового рынка. Элементы программирования глобализации определяются в [!INCLUDE[TLA#tla_net](../../../../includes/tlasharptla-net-md.md)] в `System.Globalization`.

<a name="xaml_globalization"></a>
## <a name="xaml-globalization"></a>Глобализация XAML
 [!INCLUDE[TLA#tla_xaml#initcap](../../../../includes/tlasharptla-xamlsharpinitcap-md.md)] на основе [!INCLUDE[TLA#tla_xml](../../../../includes/tlasharptla-xml-md.md)] и использует поддержку глобализации, определенную в [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] спецификации. В следующих разделах описаны некоторые [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] функций, которые следует учитывать.

<a name="char_reference"></a>
### <a name="character-references"></a>Ссылки символов
Ссылка символа сообщает модуль кода UTF16 конкретного [!INCLUDE[TLA#tla_unicode](../../../../includes/tlasharptla-unicode-md.md)] символов, он представляет в десятичном или шестнадцатеричном формате. В следующем примере показано шестнадцатеричная ссылка символа для по КОПТСКИЙ ЗАГЛАВНОЙ буквы или «Ϩ»:

```
&#1000;
```

В следующем примере шестнадцатеричная ссылка символа. Обратите внимание, что он имеет **x** перед шестнадцатеричным числом.

```
&#x3E8;
```

<a name="encoding"></a>
### <a name="encoding"></a>кодировка
 Поддерживает следующие кодировки [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] являются [!INCLUDE[TLA#tla_ascii](../../../../includes/tlasharptla-ascii-md.md)], [!INCLUDE[TLA2#tla_unicode](../../../../includes/tla2sharptla-unicode-md.md)] UTF-16 и UTF-8. Оператор кодировки должен в начале [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] документа. Если атрибут кодировки и порядок байтов отсутствуют, по умолчанию в средстве синтаксического анализа используется кодировка UTF-8. Предпочтительные кодировки: UTF-8 и UTF-16. UTF-7 не поддерживается. Следующий пример демонстрирует указание кодировки UTF-8 в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл.

```
?xml encoding="UTF-8"?
```

<a name="lang_attrib"></a>
### <a name="language-attribute"></a>Атрибут Language
 [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] использует [XML: lang](../../xaml-services/xml-lang-handling-in-xaml.md) для представления атрибута языка элемента.  Чтобы воспользоваться преимуществами <xref:System.Globalization.CultureInfo> класса, значение атрибута языка должно быть одним из параметров языка и региональных параметров, определенных классом <xref:System.Globalization.CultureInfo>. [xml:lang](../../xaml-services/xml-lang-handling-in-xaml.md) наследуется в дереве элементов (правилами XML, не обязательно из-за наследования свойства зависимости), и его значение по умолчанию — пустая строка, если оно не назначено явно.

 Атрибут языка полезно использовать для задания диалектов. Например, французский язык имеет разные написание, словарь и произношение во Франции, Квебеке, Бельгии и Швейцарии. Также китайский, японский и корейский совместно использовать точки кода в [!INCLUDE[TLA2#tla_unicode](../../../../includes/tla2sharptla-unicode-md.md)], но их идеограммы отличаются, и они используют полностью различные шрифты.

 Следующие [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] примере `fr-CA` атрибут языка для указания на канадский французский.

```xml
<TextBlock xml:lang="fr-CA">Découvrir la France</TextBlock>
```

<a name="unicode"></a>
### <a name="unicode"></a>Юникод
 [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] поддерживает все [!INCLUDE[TLA2#tla_unicode](../../../../includes/tla2sharptla-unicode-md.md)] функций, включая суррогаты. До тех пор, пока кодировка может быть сопоставлен [!INCLUDE[TLA2#tla_unicode](../../../../includes/tla2sharptla-unicode-md.md)], поддерживается. Например, GB18030 представляет определенные символы, которые сопоставляются расширениям A и B и парам суррогатов китайского, японского и корейского. Следовательно, этот набор символов полностью поддерживается. Объект [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложение может использовать <xref:System.Globalization.StringInfo> для работы со строками без понимания того, имеют ли они суррогатные пары или несамостоятельные символы.

<a name="design_intl_ui_with_xaml"></a>
## <a name="designing-an-international-user-interface-with-xaml"></a>Проектирование международного интерфейса пользователя с XAML
 В этом разделе описываются [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] функций, которые следует учитывать при написании приложения.

<a name="intl_text"></a>
### <a name="international-text"></a>Международный текст
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] включает встроенную обработку для систем письма все поддерживаемые Microsoft .NET Framework.

 В настоящее время поддерживаются следующие скрипты.

-   Арабский

-   бенгальский

-   деванагари

-   кириллица

-   Греческий

-   Гуджарати

-   гурмухи

-   Иврит

-   Идеографические скрипты

-   Каннада

-   Лаосский

-   Латиница

-   Малаялам

-   Монгольский

-   Ория

-   Сирийский

-   Тамильский

-   Телугу

-   мальдивский

-   Тайский *

-   Тибетский

 * В этом выпуске отображение и изменение текста на тайском языке поддерживается; а разбиение по словам — нет.

 В настоящее время не поддерживаются следующие скрипты.

-   Кхмерский

-   Старый хангыль (корейский)

-   бирманский

-   Сингальский

 Обработчики всех систем письма поддерживают [!INCLUDE[TLA#tla_opentype](../../../../includes/tlasharptla-opentype-md.md)] шрифты. [!INCLUDE[TLA2#tla_opentype](../../../../includes/tla2sharptla-opentype-md.md)] шрифты могут включать [!INCLUDE[TLA2#tla_opentype](../../../../includes/tla2sharptla-opentype-md.md)] макетные таблицы, которые позволяют создателям шрифтов проектировать более качественные международные и типографские шрифты. [!INCLUDE[TLA2#tla_opentype](../../../../includes/tla2sharptla-opentype-md.md)] Таблицы макетов шрифтов содержат сведения о заменах, позиционирования глифа, обоснование и относительно базового уровня, включении приложений обработки текста для улучшения макетов текста.

 [!INCLUDE[TLA2#tla_opentype](../../../../includes/tla2sharptla-opentype-md.md)] шрифты разрешить обработку больших глиф наборами с помощью [!INCLUDE[TLA2#tla_unicode](../../../../includes/tla2sharptla-unicode-md.md)] кодирования. Такая кодировка обеспечивает широкую международную поддержку и возможность использования типографских вариантов глифов.

 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] отрисовка текста реализована на базе [!INCLUDE[TLA#tla_ct](../../../../includes/tlasharptla-ct-md.md)] субпиксельной технология, которая поддерживает независимость от разрешения. Это значительно улучшает читаемость и предоставляет возможность поддержки качественных документов журнального стиля для всех скриптов.

<a name="intl_layout"></a>
### <a name="international-layout"></a>Международный макет
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет очень удобный способ поддержки горизонтальной, двунаправленной и вертикальной разметки. В инфраструктуре представления <xref:System.Windows.FrameworkElement.FlowDirection%2A> свойство может использоваться для определения макета. Ниже перечислены шаблоны направления текста:

-   *LeftToRight* — горизонтальная разметка для латиницы, восточноазиатских языков и т. д.

-   *RightToLeft* — двунаправленная разметка для арабского, иврита и т. д.

<a name="developing_localizable_apps"></a>
## <a name="developing-localizable-applications"></a>Разработка локализуемых приложений
 При написании приложений для мирового рынка следует помнить, что приложения должны быть локализуемыми. В следующих разделах указано, на что обратить внимание.

<a name="mui"></a>
### <a name="multilingual-user-interface"></a>Многоязыковой интерфейс пользователя
 Многоязыковые интерфейсы пользователя (MUI) является [!INCLUDE[TLA#tla_ms](../../../../includes/tlasharptla-ms-md.md)] поддержка переключения [!INCLUDE[TLA2#tla_ui#plural](../../../../includes/tla2sharptla-uisharpplural-md.md)] с одного языка на другой. Объект [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложение использует модель сборок для поддержки MUI. Одно приложение содержит независимые от языка сборки, а также зависимые от языка сборки вспомогательных ресурсов. Точкой входа является управляемый EXE-файл в основной сборке.  [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] загрузчик ресурсов использует преимущества [!INCLUDE[TLA2#tla_netframewk](../../../../includes/tla2sharptla-netframewk-md.md)]в диспетчер ресурсов для поддержки поиска и резервирования ресурсов. Многоязыковые вспомогательные сборки работают с одной и той же основной сборкой. Загружается сборка ресурсов зависит от <xref:System.Globalization.CultureInfo.CurrentUICulture%2A> текущего потока.

<a name="localizable_ui"></a>
### <a name="localizable-user-interface"></a>Локализуемый пользовательский интерфейс
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения используют [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] для определения их [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)]. [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] позволяет разработчикам задавать иерархию объектов с набором свойств и логику. Главным образом используется [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] является разработка [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения, но его можно использовать для задания иерархии любых [!INCLUDE[TLA#tla_clr](../../../../includes/tlasharptla-clr-md.md)] объектов. Большинство разработчиков используют [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] для указания своего приложения [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] и использовать язык программирования, например C# для реагирования на действия пользователя.

 С точки зрения ресурсов [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] разработанный для описания зависящий от языка [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] элемент ресурсов и поэтому должны быть локализуемыми для поддержки международных языков окончательный формат распространения. Так как [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] не может обрабатывать события, многие [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] приложения содержат блоки кода, чтобы сделать это. Дополнительные сведения см. в разделе [Обзор XAML (WPF)](xaml-overview-wpf.md). Код исключается и компилируется в разные двоичные файлы при [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл преобразуется в BAML-форму XAML. Форма BAML файлов XAML, изображения и другие типы управляемых объектов ресурсов внедряются во вспомогательную сборку ресурсов, которая может быть локализована на другие языки, или в основную сборку, если локализация не требуется.

> [!NOTE]
>  [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения поддерживают все [!INCLUDE[TLA2#tla_netframewk](../../../../includes/tla2sharptla-netframewk-md.md)][!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)] ресурсы, включая таблицы строк, изображений и т. д.

<a name="building_localizable_apps"></a>
### <a name="building-localizable-applications"></a>Разработка локализуемых приложений
 Локализация означает адаптацию [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] для разных языков и региональных параметров. Чтобы сделать [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] локализуемым, разработчикам нужно объединить все локализуемые ресурсы в сборку ресурсов приложения. Сборка ресурсов локализуется на разные языки, и код программной части использует модуль управления ресурсами [!INCLUDE[TLA#tla_api](../../../../includes/tlasharptla-api-md.md)] для загрузки. Один из файлов, необходимых для [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения — это файл проекта (.proj). Все ресурсы, используемые в приложении, необходимо включить в файл проекта. В следующем примере из CSPROJ-файла показано, как это сделать.

```xml
<Resource Include="data\picture1.jpg"/>
<EmbeddedResource Include="data\stringtable.en-US.restext"/>
```

 Для использования ресурсов в приложении создайте экземпляр <xref:System.Resources.ResourceManager> и загрузки ресурсов, которые вы хотите использовать. В следующем примере показано, как это сделать.

 [!code-csharp[LocalizationResources#2](~/samples/snippets/csharp/VS_Snippets_Wpf/LocalizationResources/CSharp/page1.xaml.cs#2)]

<a name="using_clickonce"></a>
## <a name="using-clickonce-with-localized-applications"></a>Использование ClickOnce с локализованными приложениями
 ClickOnce — это новая технология развертывания Windows Forms, которая будет поставляться вместе с Visual Studio 2005. Она позволяет устанавливать и обновлять веб-приложения. При локализации приложения, которое было развернуто с помощью ClickOnce, просмотреть его можно только на локализованном языке и с соответствующими региональными параметрами. Например, если развернутое приложение локализуется на японский его можно просматривать только на японском языке [!INCLUDE[TLA#tla_win](../../../../includes/tlasharptla-win-md.md)] не на английском языке Windows. Это представляет проблему, так как это распространенный сценарий для японского пользователям запускать английской версии Windows.

 Чтобы решить эту проблему, можно задать резервный атрибут нейтрального языка. Разработчик приложения может при необходимости удалить ресурсы из основной сборки и указать, что ресурсы можно найти во вспомогательной сборке, соответствующей определенной культуре. Для управления этим процессом используйте <xref:System.Resources.NeutralResourcesLanguageAttribute>. Конструктор <xref:System.Resources.NeutralResourcesLanguageAttribute> класс имеет две подписи: одна принимает <xref:System.Resources.UltimateResourceFallbackLocation> для указания расположения где <xref:System.Resources.ResourceManager> должен извлекать резервные ресурсы: основную или вспомогательную сборку. В следующем примере показано использование атрибута. Для конечного расположения запасных, код вызывает <xref:System.Resources.ResourceManager> для поиска ресурсов в подкаталоге «de» каталога текущей выполняемой сборке.

```
[assembly: NeutralResourcesLanguageAttribute(
    "de" , UltimateResourceFallbackLocation.Satellite)]
```

## <a name="see-also"></a>См. также

- [Общие сведения о глобализации и локализации WPF](wpf-globalization-and-localization-overview.md)
