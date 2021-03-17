---
title: Практическое руководство. Реализация проверки привязки
ms.date: 03/30/2017
helpviewer_keywords:
- validation of binding [WPF]
- data binding [WPF], validation of binding
- binding [WPF], validation of
ms.assetid: eb98b33d-9866-49ae-b981-bc5ff20d607a
ms.openlocfilehash: 3950df8b6f4b48a035c6ebf37d8d65c18cb82e1e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59197221"
---
# <a name="how-to-implement-binding-validation"></a>Практическое руководство. Реализация проверки привязки
В этом примере показано, как использовать <xref:System.Windows.Controls.Validation.ErrorTemplate%2A> и триггер стиля для предоставления визуальной обратной связи, чтобы информировать пользователей, если введено недопустимое значение, на основании пользовательского правила проверки.  
  
## <a name="example"></a>Пример  
 Текстовое содержимое <xref:System.Windows.Controls.TextBox> в следующем примере, привязан к `Age` свойства (типа int) объекта источника привязки с именем `ods`. Привязка настроена на использование правила проверки с именем `AgeRangeRule` так, чтобы при вводе нечисловых символов или значения меньше 21 или больше 130 рядом с текстовым полем появился красный восклицательный знак и подсказка с сообщением об ошибке, когда пользователь наводит указатель мыши на текстовое поле.  
  
 [!code-xaml[BindValidation#2](~/samples/snippets/csharp/VS_Snippets_Wpf/BindValidation/CSharp/Window1.xaml#2)]  
  
 В следующем примере показана реализация `AgeRangeRule`, который наследует от <xref:System.Windows.Controls.ValidationRule> и переопределяет <xref:System.Windows.Controls.ValidationRule.Validate%2A> метод. Метод Int32.Parse() вызывается для значения, чтобы убедиться в том, что он не содержит недопустимых символов. <xref:System.Windows.Controls.ValidationRule.Validate%2A> Возвращает метод <xref:System.Windows.Controls.ValidationResult> , указывающее, если значение допустимо на основе ли исключение перехватывается во время синтаксического анализа и от того, является ли значение возраста за пределами нижнюю и верхнюю границы.  
  
 [!code-csharp[BindValidation#3](~/samples/snippets/csharp/VS_Snippets_Wpf/BindValidation/CSharp/AgeRangeRule.cs#3)]  
  
 В следующем примере показано пользовательский <xref:System.Windows.Controls.ControlTemplate> `validationTemplate` , создает красный восклицательный знак для уведомления пользователя об ошибке проверки. Шаблоны элементов управления используются для переопределения внешнего вида элемента управления.  
  
 [!code-xaml[BindValidation#4](~/samples/snippets/csharp/VS_Snippets_Wpf/BindValidation/CSharp/Window1.xaml#4)]  
  
 Как показано в следующем примере <xref:System.Windows.Controls.ToolTip> , в котором показано сообщение об ошибке создается с использованием стиля с именем `textBoxInError`. Если значение <xref:System.Windows.Controls.Validation.HasError%2A> — `true`, триггер задает для подсказки текущего <xref:System.Windows.Controls.TextBox> для первой ошибки проверки. <xref:System.Windows.Data.Binding.RelativeSource%2A> Присваивается <xref:System.Windows.Data.RelativeSourceMode.Self>, ссылающегося на текущий элемент.  
  
 [!code-xaml[BindValidation#5](~/samples/snippets/csharp/VS_Snippets_Wpf/BindValidation/CSharp/Window1.xaml#5)]  
  
 Полный пример см. в [Примере проверки привязки](https://go.microsoft.com/fwlink/?LinkID=159972).  
  
 Обратите внимание, что если вы не предоставите пользовательский <xref:System.Windows.Controls.Validation.ErrorTemplate%2A> отображается шаблон ошибки по умолчанию для предоставления пользователю визуальной обратной связи при ошибке проверки. См. "Проверка данных" в разделе [Общие сведения о привязке данных](data-binding-overview.md). Кроме того, [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет встроенное правило проверки, которое отслеживает исключения, получаемые во время обновления свойства источника привязки. Дополнительные сведения см. в разделе <xref:System.Windows.Controls.ExceptionValidationRule>.  
  
## <a name="see-also"></a>См. также

- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)
