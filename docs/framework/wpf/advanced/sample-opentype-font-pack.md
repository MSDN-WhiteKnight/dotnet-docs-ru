---
title: Образец пакета шрифтов OpenType
ms.date: 03/30/2017
helpviewer_keywords:
- OpenType font pack [WPF]
- fonts [WPF], OpenType font pack
- typography [WPF], OpenType font pack
ms.assetid: 56b46fa1-a44e-419b-8f14-25ad51c715c3
ms.openlocfilehash: 96a0a5feaf14a7f040402681e90fba8f9766324b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59199041"
---
# <a name="sample-opentype-font-pack"></a>Образец пакета шрифтов OpenType
В этом разделе рассматриваются образцы шрифтов [!INCLUDE[TLA#tla_opentype](../../../../includes/tlasharptla-opentype-md.md)], которые распространяются вместе с [!INCLUDE[TLA2#tla_wcsdk](../../../../includes/tla2sharptla-wcsdk-md.md)]. Образцы шрифтов поддерживают расширенные функции [!INCLUDE[TLA#tla_opentype](../../../../includes/tlasharptla-opentype-md.md)], которые могут использоваться приложениями [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)].  

<a name="overview"></a>   
## <a name="fonts-in-the-opentype-font-pack"></a>Шрифты в пакете шрифтов OpenType  
 [!INCLUDE[TLA2#tla_wcsdk](../../../../includes/tla2sharptla-wcsdk-md.md)] предоставляет набор образцов шрифтов [!INCLUDE[TLA#tla_opentype](../../../../includes/tlasharptla-opentype-md.md)], которые можно использовать при создании приложений [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)]. Образцы шрифтов предоставляются по лицензии от Ascender Corporation. Эти шрифты реализуют только подмножество общих функций, определенных в формате [!INCLUDE[TLA#tla_opentype](../../../../includes/tlasharptla-opentype-md.md)]. В следующей таблице приведены названия образцов шрифтов [!INCLUDE[TLA#tla_opentype](../../../../includes/tlasharptla-opentype-md.md)].  
  
|**name**|**Файл**|  
|--------------|--------------|  
|Kootenay|Kooten.ttf|  
|Lindsey|Linds.ttf|  
|Miramonte|Miramo.ttf|  
|Miramonte Bold|Miramob.ttf|  
|Pericles|Peric.ttf|  
|Pericles Light|Pericl.ttf|  
|Pescadero|Pesca.ttf|  
|Pescadero Bold|Pescab.ttf|  
  
 На следующем рисунке показано, как выглядят образцы шрифтов [!INCLUDE[TLA#tla_opentype](../../../../includes/tlasharptla-opentype-md.md)].  
  
 ![Список имен шрифтов в примере пакета шрифтов](./media/sample-opentype-font-pack/font-names-sample-pack.gif)  
  
 Образцы шрифтов предоставляются по лицензии от Ascender Corporation. Ascender является поставщиком передовых решений для шрифтов. Для лицензирования расширенных или настраиваемых версий образцов шрифтов см. [веб-сайт корпорации Ascender](https://go.microsoft.com/fwlink/?LinkId=182627).  
  
> [!NOTE]
>  Являясь разработчиком, вы несете ответственность за наличие у вас необходимых лицензионных прав на любой шрифт, который вы включаете в приложение или распространяете иным образом.  
  
<a name="installing_the_fonts"></a>   
## <a name="installing-the-fonts"></a>Установка шрифтов  
 Можно установить образцы шрифтов [!INCLUDE[TLA#tla_opentype](../../../../includes/tlasharptla-opentype-md.md)] в каталог шрифтов по умолчанию [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)], **\WINDOWS\Fonts**. Для установки шрифтов используйте панель управления Fonts. После установки шрифтов на вашем компьютере они будут доступны для всех приложений, которые ссылаются на шрифты [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)] по умолчанию. Можно отобразить характерный набор символов в нескольких размерах шрифта, дважды нажав файл шрифта. На следующем снимке экрана показан файл шрифта Lindsey, Linds.ttf.  
  
 ![Шрифта Lindsey &#40;OpenType&#41;](./media/typographyinwpf-04.png "TypographyInWPF_04")  
Отображение шрифта Lindsey  
  
<a name="using_the_fonts"></a>   
## <a name="using-the-fonts"></a>Использование шрифтов  
 Есть два способа использования шрифтов в вашем приложении. Можно добавить шрифты в приложение в виде элементов содержимого проекта, которые не внедряются в качестве ресурсов в сборку. Кроме того, можно добавить шрифты в приложение в виде элементов ресурсов проекта, которые внедряются в файлы сборки приложения. Дополнительные сведения см. в разделе [Упаковка шрифтов с приложениями](packaging-fonts-with-applications.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Documents.Typography>
- [Возможности шрифта OpenType](opentype-font-features.md)
- [Упаковка шрифтов с приложениями](packaging-fonts-with-applications.md)
