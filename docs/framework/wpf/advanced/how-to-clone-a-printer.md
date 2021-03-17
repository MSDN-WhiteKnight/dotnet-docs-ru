---
title: Практическое руководство. Клонирование принтера
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- print queues [WPF]
- cloning printers [WPF]
- printers [WPF], cloning
- print queues [WPF], cloning
- cloning print queues [WPF]
ms.assetid: dd6997c9-fe04-40f8-88a6-92e3ac0889eb
ms.openlocfilehash: 09a445da068f0141b9526e0228df8be0105498c6
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59310464"
---
# <a name="how-to-clone-a-printer"></a>Практическое руководство. Клонирование принтера
Большинство компаний рано или поздно купит нескольких принтеров той же модели. Как правило они все устанавливаются с практически одинаковыми параметрами. Установка каждого принтера может занимать много времени и подвержено ошибкам. <xref:System.Printing.IndexedProperties?displayProperty=nameWithType> Пространства имен и <xref:System.Printing.PrintServer.InstallPrintQueue%2A> класс, который предоставляется через Microsoft .NET Framework дает возможность мгновенно установить любое число дополнительных очередей печати, которые копируются из существующей очереди печати.  
  
## <a name="example"></a>Пример  
 В следующем примере второй очереди печати клонируется из существующей очереди печати. Второй отличающимся от первого только в его имя, расположение, порт и состояние общего доступа. Ниже приведены основные действия для этого.  
  
1. Создание <xref:System.Printing.PrintQueue> объект для существующего принтера, который нужно клонировать.  
  
2. Создание <xref:System.Printing.IndexedProperties.PrintPropertyDictionary> из <xref:System.Printing.PrintSystemObject.PropertiesCollection%2A> из <xref:System.Printing.PrintQueue>. <xref:System.Collections.DictionaryEntry.Value%2A> Каждой записи в этом словаре является объектом одного из типов, производных от <xref:System.Printing.IndexedProperties.PrintProperty>. Существует два способа установки значения объекта, содержащегося в данном словаре.  
  
    -   Использование словаря **удалить** и <xref:System.Printing.IndexedProperties.PrintPropertyDictionary.Add%2A> методов, чтобы удалить запись, а затем добавьте его повторно с требуемым значением.  
  
    -   Использование словаря <xref:System.Printing.IndexedProperties.PrintPropertyDictionary.SetProperty%2A> метод.  
  
     В приведенном ниже примере показаны оба способа.  
  
3. Создание <xref:System.Printing.IndexedProperties.PrintBooleanProperty> и задайте его <xref:System.Printing.IndexedProperties.PrintProperty.Name%2A> для «IsShared» и его <xref:System.Printing.IndexedProperties.PrintBooleanProperty.Value%2A> для `true`.  
  
4. Используйте <xref:System.Printing.IndexedProperties.PrintBooleanProperty> объект значение <xref:System.Printing.IndexedProperties.PrintPropertyDictionary>в записи «IsShared».  
  
5. Создание <xref:System.Printing.IndexedProperties.PrintStringProperty> и задайте его <xref:System.Printing.IndexedProperties.PrintProperty.Name%2A> для «ShareName» и его <xref:System.Printing.IndexedProperties.PrintStringProperty.Value%2A> — соответствующую <xref:System.String>.  
  
6. Используйте <xref:System.Printing.IndexedProperties.PrintStringProperty> объект значение <xref:System.Printing.IndexedProperties.PrintPropertyDictionary>в записи «Ресурс».  
  
7. Создайте другой <xref:System.Printing.IndexedProperties.PrintStringProperty> и задайте его <xref:System.Printing.IndexedProperties.PrintProperty.Name%2A> «Расположение» и его <xref:System.Printing.IndexedProperties.PrintStringProperty.Value%2A> — соответствующую <xref:System.String>.  
  
8. Используйте второй <xref:System.Printing.IndexedProperties.PrintStringProperty> объект значение <xref:System.Printing.IndexedProperties.PrintPropertyDictionary>в записи «Местоположение».  
  
9. Создайте массив <xref:System.String>s. Каждый элемент является имя порта на сервере.  
  
10. Используйте <xref:System.Printing.PrintServer.InstallPrintQueue%2A> для установки нового принтера с новыми значениями.  
  
 Пример приведен ниже.  
  
 [!code-csharp[ClonePrinter#ClonePrinter](~/samples/snippets/csharp/VS_Snippets_Wpf/ClonePrinter/CSharp/Program.cs#cloneprinter)]
 [!code-vb[ClonePrinter#ClonePrinter](~/samples/snippets/visualbasic/VS_Snippets_Wpf/ClonePrinter/visualbasic/program.vb#cloneprinter)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Printing.IndexedProperties>
- <xref:System.Printing.IndexedProperties.PrintPropertyDictionary>
- <xref:System.Printing.LocalPrintServer>
- <xref:System.Printing.PrintQueue>
- <xref:System.Collections.DictionaryEntry>
- [Документы в WPF](documents-in-wpf.md)
- [Общие сведения о печати](printing-overview.md)
