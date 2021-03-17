---
title: Рисование форматированного текста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- text [WPF]
- typography [WPF], drawing formatted text
- formatted text [WPF]
- drawing [WPF], formatted text
ms.assetid: b1d851c1-331c-4814-9964-6fe769db6f1f
ms.openlocfilehash: a61031c36dea84449ad07175287bf834544df886
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59129094"
---
# <a name="drawing-formatted-text"></a>Рисование форматированного текста
В этом разделе представлен обзор функций <xref:System.Windows.Media.FormattedText> объекта. Этот объект предоставляет низкоуровневый элемент управления для рисования текста в приложениях [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)].  

## <a name="technology-overview"></a>Общие сведения о технологии  
 <xref:System.Windows.Media.FormattedText> Объект позволяет рисовать многострочный текст, в котором каждый символ в текст можно форматировать по отдельности. В следующем примере показан текст, к которому применено несколько форматов.  
  
 ![Отображенный текст с использованием объекта FormattedText](./media/typography-in-wpf/text-formatted-linear-gradient.jpg)  
  
> [!NOTE]
>  Для разработчиков, осуществляющих переход с API [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)], в таблице из раздела [Миграция Win32](#win32_migration) перечислены флаги DrawText [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] и примерный эквивалент в [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)].  
  
### <a name="reasons-for-using-formatted-text"></a>Причины использования форматированного текста  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] содержит несколько элементов управления для рисования текста на экране. Каждый элемент управления предназначен для своего сценария и имеет собственный список функций и ограничений. В общем случае <xref:System.Windows.Controls.TextBlock> элемент должен использоваться при необходимости, например короткого предложения в ограниченная поддержка текста [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)]. <xref:System.Windows.Controls.Label> может использоваться, если требуется Минимальная текстовая поддержка. Дополнительные сведения см. в разделе [Документы в WPF](documents-in-wpf.md).  
  
 <xref:System.Windows.Media.FormattedText> Объект предоставляет больше функций, чем форматирования текста [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] текстовых элементов управления и могут быть полезны в тех случаях, когда использовать текст как декоративный элемент. Дополнительные сведения см. в следующем разделе: [Преобразование форматированного текста в геометрический объект](#converting_formatted_text).  
  
 Кроме того <xref:System.Windows.Media.FormattedText> объект удобна для создания ориентированных на текст <xref:System.Windows.Media.DrawingVisual>-объекты, производные от. <xref:System.Windows.Media.DrawingVisual> — Это упрощенный класс, используемый для отрисовки фигур, изображений и текста. Дополнительные сведения см. в разделе [Пример проверки нажатия с использованием DrawingVisuals](https://go.microsoft.com/fwlink/?LinkID=159994).  
  
## <a name="using-the-formattedtext-object"></a>Использование объекта FormattedText  
 Чтобы создать форматированный текст, вызовите <xref:System.Windows.Media.FormattedText.%23ctor%2A> конструктор для создания <xref:System.Windows.Media.FormattedText> объекта. После создания исходной строки форматированного текста можно применить ряд стилей форматирования.  
  
 Используйте <xref:System.Windows.Media.FormattedText.MaxTextWidth%2A> свойство для ограничения текста по ширине. Текст будет автоматически перенесен, чтобы заданная ширина не была нарушена. Используйте <xref:System.Windows.Media.FormattedText.MaxTextHeight%2A> свойство для ограничения текста по высоте. Если текст выходит за указанные пределы по высоте, отображается многоточие (…).  
  
 ![Текст, отображаемый с переноса слов и многоточием.](./media/drawing-formatted-text/formatted-text-wordwrap-ellipsis.png)    
  
 К одному или более символам можно применить несколько стилей форматирования. Например, можно вызвать оба <xref:System.Windows.Media.FormattedText.SetFontSize%2A> и <xref:System.Windows.Media.FormattedText.SetForegroundBrush%2A> методы для изменения форматирования первые пять символов в тексте.  
  
 В следующем примере кода создается <xref:System.Windows.Media.FormattedText> объекта и затем применяется несколько стилей форматирования к тексту.  
  
 [!code-csharp[FormattedTextSnippets#FormattedTextSnippets1](~/samples/snippets/csharp/VS_Snippets_Wpf/FormattedTextSnippets/CSharp/Window1.xaml.cs#formattedtextsnippets1)]
 [!code-vb[FormattedTextSnippets#FormattedTextSnippets1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/FormattedTextSnippets/visualbasic/window1.xaml.vb#formattedtextsnippets1)]  
  
### <a name="font-size-unit-of-measure"></a>Единица измерения "Размер шрифта"  
 Как и в случае с другими текстовыми объектами в [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] приложений, <xref:System.Windows.Media.FormattedText> объект использует аппаратно независимые пиксели в качестве единицы измерения. Однако большинство приложений [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] используют в качестве единицы измерения точки. Если требуется использовать отображаемый текст в приложениях [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] в единицах точек, необходимо преобразовать [!INCLUDE[TLA#tla_dipixel#plural](../../../../includes/tlasharptla-dipixelsharpplural-md.md)] в точки. В следующем примере кода показано выполнение этого преобразования.  
  
 [!code-csharp[FormattedTextSnippets#FormattedTextSnippets2](~/samples/snippets/csharp/VS_Snippets_Wpf/FormattedTextSnippets/CSharp/Window1.xaml.cs#formattedtextsnippets2)]
 [!code-vb[FormattedTextSnippets#FormattedTextSnippets2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/FormattedTextSnippets/visualbasic/window1.xaml.vb#formattedtextsnippets2)]  
  
<a name="converting_formatted_text"></a>   
### <a name="converting-formatted-text-to-a-geometry"></a>Преобразование форматированного текста в геометрический объект  
 Можно преобразовать форматированный текст в <xref:System.Windows.Media.Geometry> объектов, что позволяет создавать другие типы наглядного текста. Например, можно создать <xref:System.Windows.Media.Geometry> объект, основанный на контуре строки текста.  
  
 ![Оконтуривание текста с использованием кисти линейного градиента](./media/typography-in-wpf/text-outline-linear-gradient.jpg)    
  
 В следующих примерах показаны несколько способов создания визуальных эффектов посредством изменения штриха, заливки и выделения преобразованного текста.  
  
 ![Текст с различными цветами для заполнения штриха](./media/typography-in-wpf/fill-stroke-text-effect.jpg)  
  
 ![Текст с кистью изображения, примененной к штриху](./media/typography-in-wpf/image-brush-application.jpg)
  
 ![Текст с кистью изображения, примененной для вычерчивания и выделения](./media/typography-in-wpf/image-brush-text-application.jpg)
  
 Если текст преобразуется в <xref:System.Windows.Media.Geometry> объекта, он больше не является набором символов — изменение символов в текстовой строке невозможно. Тем не менее можно повлиять на внешний вид преобразованного текст, изменив его свойства штриха и заливки. Штрих — это контур преобразованного текста; заливка — это область внутри контура преобразованного текста. Дополнительные сведения см. в разделе [Создание контурного текста](how-to-create-outlined-text.md).  
  
 Можно также преобразовать форматированный текст в <xref:System.Windows.Media.PathGeometry> и использовать объект для выделения текста. Например, можно применить анимацию к <xref:System.Windows.Media.PathGeometry> таким образом, чтобы анимация повторяла контур форматированного текста.  
  
 В следующем примере показано форматированный текст, который был преобразован в <xref:System.Windows.Media.PathGeometry> объекта. Анимированное многоточие повторяет путь штрихов отрисованного текста.  
  
 ![Сфера, следующая по геометрическому пути текста](./media/drawing-formatted-text/sphere-following-geometry-path.gif)  
Сфера, следующая по геометрическому пути текста  
  
 Дополнительные сведения см. в разделе [Как Создание анимации PathGeometry для текста](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/ms743610(v=vs.100)).  
  
 Можно создать другие интересные сферы применения форматированного текста после преобразования в <xref:System.Windows.Media.PathGeometry> объекта. Например, можно обрезать видео для отображения внутри текста.  
  
 ![Отображение видео по геометрическому пути текста](./media/drawing-formatted-text/video-displaying-text-path-geometry.png)
  
<a name="win32_migration"></a>   
## <a name="win32-migration"></a>Миграция Win32  
 Возможности <xref:System.Windows.Media.FormattedText> для рисования текста похожи на возможности [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] функции DrawText. Для разработчиков, осуществляющих переход с API [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)], в таблице перечислены флаги DrawText [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] и примерный эквивалент в [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)].  
  
|Флаг DrawText|Эквивалент WPF|Примечания|  
|-------------------|--------------------|-----------|  
|DT_BOTTOM|<xref:System.Windows.Media.FormattedText.Height%2A>|Используйте <xref:System.Windows.Media.FormattedText.Height%2A> свойство для вычисления соответствующей [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] позиции DrawText «y».|  
|DT_CALCRECT|<xref:System.Windows.Media.FormattedText.Height%2A>, <xref:System.Windows.Media.FormattedText.Width%2A>|Используйте <xref:System.Windows.Media.FormattedText.Height%2A> и <xref:System.Windows.Media.FormattedText.Width%2A> для вычисления выходного прямоугольника.|  
|DT_CENTER|<xref:System.Windows.Media.FormattedText.TextAlignment%2A>|Используйте <xref:System.Windows.Media.FormattedText.TextAlignment%2A> свойство со значением, равным <xref:System.Windows.TextAlignment.Center>.|  
|DT_EDITCONTROL|Нет|Не требуется. Ширина пробелов и отрисовка последней строки соответствуют этим параметрам в элементе управления редактированием среды.|  
|DT_END_ELLIPSIS|<xref:System.Windows.Media.FormattedText.Trimming%2A>|Используйте <xref:System.Windows.Media.FormattedText.Trimming%2A> свойством со значением <xref:System.Windows.TextTrimming.CharacterEllipsis>.<br /><br /> Используйте <xref:System.Windows.TextTrimming.WordEllipsis> для получения [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] DT_END_ELLIPSIS с конечным многоточием — в этом случае символ многоточия происходит только по словам, которые не помещаются на одной строке.|  
|DT_EXPAND_TABS|Нет|Не требуется. Символы табуляции автоматически расширяются до точек каждые 4 размера максимального пробела (это примерно соответствует ширине 8 независимых от языка символов).|  
|DT_EXTERNALLEADING|Нет|Не требуется. Внешнее ведение всегда включается в междустрочный интервал. Используйте <xref:System.Windows.Media.FormattedText.LineHeight%2A> свойство для создания определяемого пользователем междустрочного интервала.|  
|DT_HIDEPREFIX|Нет|Не поддерживается. Удалите знак «&» из строки перед созданием <xref:System.Windows.Media.FormattedText> объекта.|  
|DT_LEFT|<xref:System.Windows.Media.FormattedText.TextAlignment%2A>|Это выравнивание текста по умолчанию. Используйте <xref:System.Windows.Media.FormattedText.TextAlignment%2A> свойство со значением, равным <xref:System.Windows.TextAlignment.Left>. (только WPF)|  
|DT_MODIFYSTRING|Нет|Не поддерживается.|  
|DT_NOCLIP|<xref:System.Windows.Media.Visual.VisualClip%2A>|Отсечение не происходит автоматически. Если требуется, чтобы обрезать текст, используйте <xref:System.Windows.Media.Visual.VisualClip%2A> свойство.|  
|DT_NOFULLWIDTHCHARBREAK|Нет|Не поддерживается.|  
|DT_NOPREFIX|Нет|Не требуется. Символ & в строке всегда рассматривается как обычный символ.|  
|DT_PATHELLIPSIS|Нет|Используйте <xref:System.Windows.Media.FormattedText.Trimming%2A> свойством со значением <xref:System.Windows.TextTrimming.WordEllipsis>.|  
|DT_PREFIX|Нет|Не поддерживается. Если вы хотите использовать для текста, таких как сочетания клавиш или ссылки, используйте <xref:System.Windows.Media.FormattedText.SetTextDecorations%2A> метод.|  
|DT_PREFIXONLY|Нет|Не поддерживается.|  
|DT_RIGHT|<xref:System.Windows.Media.FormattedText.TextAlignment%2A>|Используйте <xref:System.Windows.Media.FormattedText.TextAlignment%2A> свойство со значением, равным <xref:System.Windows.TextAlignment.Right>. (только WPF)|  
|DT_RTLREADING|<xref:System.Windows.Media.FormattedText.FlowDirection%2A>|Задайте для свойства <xref:System.Windows.Media.FormattedText.FlowDirection%2A> значение <xref:System.Windows.FlowDirection.RightToLeft>.|  
|DT_SINGLELINE|Нет|Не требуется. <xref:System.Windows.Media.FormattedText> объекты ведут себя как Однострочные элементы управления, если не либо <xref:System.Windows.Media.FormattedText.MaxTextWidth%2A> свойству или текст не содержит возврата каретки и перевода строки (CR/LF).|  
|DT_TABSTOP|Нет|Отсутствует поддержка пользовательских позиций табуляции.|  
|DT_TOP|<xref:System.Windows.Media.FormattedText.Height%2A>|Не требуется. По умолчанию используется выравнивание по верхнему краю. Другие значения вертикального позиционирования можно определить с помощью <xref:System.Windows.Media.FormattedText.Height%2A> свойство для вычисления соответствующей [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] позиции DrawText «y».|  
|DT_VCENTER|<xref:System.Windows.Media.FormattedText.Height%2A>|Используйте <xref:System.Windows.Media.FormattedText.Height%2A> свойство для вычисления соответствующей [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] позиции DrawText «y».|  
|DT_WORDBREAK|Нет|Не требуется. Перенос слов выполняется автоматически с <xref:System.Windows.Media.FormattedText> объектов. Его нельзя отключить.|  
|DT_WORD_ELLIPSIS|<xref:System.Windows.Media.FormattedText.Trimming%2A>|Используйте <xref:System.Windows.Media.FormattedText.Trimming%2A> свойством со значением <xref:System.Windows.TextTrimming.WordEllipsis>.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.FormattedText>
- [Документы в WPF](documents-in-wpf.md)
- [Оформление в WPF](typography-in-wpf.md)
- [Создание контурного текста](how-to-create-outlined-text.md)
- [Практическое руководство. Создание анимации PathGeometry для текста](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/ms743610(v=vs.100))
