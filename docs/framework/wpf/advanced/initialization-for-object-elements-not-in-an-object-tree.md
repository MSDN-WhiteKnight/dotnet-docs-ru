---
title: Инициализация для элементов типа Object вне дерева объектов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- logical tree [WPF]
- visual tree [WPF]
- elements [WPF], initializing
- initializing elements [WPF]
ms.assetid: 7b8dfc9b-46ac-4ce8-b7bb-035734d688b7
ms.openlocfilehash: 6f3c8611b83977431038573eb1c5c880acbefdc4
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59108970"
---
# <a name="initialization-for-object-elements-not-in-an-object-tree"></a>Инициализация для элементов типа Object вне дерева объектов
За некоторые аспекты инициализации Windows Presentation Foundation (WPF) отвечают процессы, которые обычно предполагают, что элемент подключен либо к логическому, либо к визуальному дереву. В этом разделе описываются действия, необходимые для инициализации элемента, который не подключен ни к одному из деревьев.  

## <a name="elements-and-the-logical-tree"></a>Элементы и логическое дерево  
 При создании экземпляра класса Windows Presentation Foundation (WPF) в коде следует иметь в виду, что несколько аспектов инициализации объекта для класса Windows Presentation Foundation (WPF) преднамеренно не являются частью кода, выполняющегося при вызове конструктора класса. Большая часть визуального представления элемента управления, особенно для класса элемента управления, не определяется конструктором. Вместо этого визуальное представление определяется шаблоном элемента управления. Шаблон может быть получен из различных источников, но наиболее часто он берется из стилей темы. Шаблоны фактически выполняют позднее связывание. Необходимый шаблон не присоединяется к элементу управления до тех пор, пока элемент управления не будет подготовлен для макета. А элемент управления не готов для макета до тех пор, пока он не будет присоединен к логическому дереву, которое подключается к отрисовываемой поверхности в корневом элементе. Именно элемент корневого уровня инициирует отрисовку всех дочерних элементов, как определено в логическом дереве.  
  
 Визуальное дерево также участвует в этом процессе. Элементы, которые являются частью визуального дерева посредством шаблонов, также полностью не создаются до тех пор, пока не произойдет подключение.  
  
 Последствием этого является то, что для определенных операций, зависящих от завершенных визуальных характеристик элемента, требуется выполнение дополнительных действий. Примером является попытка получить визуальные характеристики класса, который был создан, но еще не присоединен к дереву. Например если вы хотите вызвать <xref:System.Windows.Media.Imaging.RenderTargetBitmap.Render%2A> на <xref:System.Windows.Media.Imaging.RenderTargetBitmap> и визуальный элемент не подключен к дереву, этот элемент не визуально завершена, пока не будут выполнены дополнительные действия по инициализации.  
  
### <a name="using-begininit-and-endinit-to-initialize-the-element"></a>Использование BeginInit и EndInit для инициализации элемента  
 Различные классы в WPF реализовать <xref:System.ComponentModel.ISupportInitialize> интерфейс. Использовании <xref:System.ComponentModel.ISupportInitialize.BeginInit%2A> и <xref:System.ComponentModel.ISupportInitialize.EndInit%2A> методы интерфейса для обозначения области кода, содержащей действия для инициализации (такие как установка значений свойств, влияющих на отрисовку). После <xref:System.ComponentModel.ISupportInitialize.EndInit%2A> вызывается в последовательности система макета может обработать элемент и начать поиск неявного стиля.  
  
 Если элемент при установке свойств на <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement> производного класса, то можно вызвать версии класса <xref:System.Windows.FrameworkElement.BeginInit%2A> и <xref:System.Windows.FrameworkElement.EndInit%2A> вместо приведения к <xref:System.ComponentModel.ISupportInitialize>.  
  
### <a name="sample-code"></a>Пример кода  
 Ниже приведен пример кода для консольного приложения, использующего отрисовки API и <xref:System.Windows.Markup.XamlReader.Load%28System.IO.Stream%29?displayProperty=nameWithType> свободного [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл для иллюстрации правильного размещения <xref:System.Windows.FrameworkElement.BeginInit%2A> и <xref:System.Windows.FrameworkElement.EndInit%2A> относительно других [!INCLUDE[TLA2#tla_api](../../../../includes/tla2sharptla-api-md.md)] вызовы корректировать, влияющих на отрисовку.  
  
 В этом примере иллюстрируется только основная функция. Функции `Rasterize` и `Save` (не показаны) являются служебными функциями, которые отвечают за обработку изображения и ввод-вывод.  
  
 [!code-csharp[InitializeElements#Main](~/samples/snippets/csharp/VS_Snippets_Wpf/InitializeElements/CSharp/initializeelements.cs#main)]
   
  
## <a name="see-also"></a>См. также

- [Деревья в WPF](trees-in-wpf.md)
- [Общие сведения об отрисовке графики в WPF](../graphics-multimedia/wpf-graphics-rendering-overview.md)
- [Обзор XAML (WPF)](xaml-overview-wpf.md)
