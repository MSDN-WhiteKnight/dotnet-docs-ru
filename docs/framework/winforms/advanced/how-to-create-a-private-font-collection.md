---
title: Практическое руководство. Создание частной коллекции шрифтов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- private font collections [Windows Forms], creating
- fonts [Windows Forms], creating private collections
ms.assetid: 6533d5e5-a8dc-4b76-9fc4-3bf75c8b9212
ms.openlocfilehash: f78d48c88b72388676f5e7ae963b98d8f1b4beac
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59210695"
---
# <a name="how-to-create-a-private-font-collection"></a>Практическое руководство. Создание частной коллекции шрифтов
<xref:System.Drawing.Text.PrivateFontCollection> Класс наследует от <xref:System.Drawing.Text.FontCollection> абстрактного базового класса. Можно использовать <xref:System.Drawing.Text.PrivateFontCollection> объект для сохранения набора шрифты, специально для вашего приложения. Частной коллекции может включать установленных системных шрифтов, а также шрифты, которые не были установлены на компьютере. Чтобы добавить файл шрифта частной коллекции, вызовите <xref:System.Drawing.Text.PrivateFontCollection.AddFontFile%2A> метод <xref:System.Drawing.Text.PrivateFontCollection> объекта.  
  
 <xref:System.Drawing.Text.FontCollection.Families%2A> Свойство <xref:System.Drawing.Text.PrivateFontCollection> объект содержит массив <xref:System.Drawing.FontFamily> объектов.  
  
 Количество семейств шрифтов в частной коллекции не обязательно совпадает с количеством файлов шрифтов, которые были добавлены в коллекцию. Например предположим, что файлы, ArialBd.tff Times.tff и TimesBd.tff, добавленные в коллекцию. Будет существовать три файла, но только два семейства в коллекции, так как Times.tff и TimesBd.tff относятся к одному семейству.  
  
## <a name="example"></a>Пример  
 В следующем примере добавляется следующих трех шрифта файлов <xref:System.Drawing.Text.PrivateFontCollection> объекта:  
  
-   C:\\*systemroot*\Fonts\Arial.tff (Arial, обычный)  
  
-   C:\\*systemroot*\Fonts\CourBI.tff (Courier New, полужирный курсив)  
  
-   C:\\*systemroot*\Fonts\TimesBd.tff (Times New Roman, полужирным шрифтом)  
  
 Код извлекает массив <xref:System.Drawing.FontFamily> объектов из <xref:System.Drawing.Text.FontCollection.Families%2A> свойство <xref:System.Drawing.Text.PrivateFontCollection> объекта.  
  
 Для каждого <xref:System.Drawing.FontFamily> объекта в коллекции, этот код вызывает <xref:System.Drawing.FontFamily.IsStyleAvailable%2A> метод, чтобы определить, будут ли доступны различные стили (обычный, полужирный, курсив, полужирный курсив, подчеркнутый и зачеркнутый). Аргументы, передаваемые <xref:System.Drawing.FontFamily.IsStyleAvailable%2A> метод являются членами <xref:System.Drawing.FontStyle> перечисления.  
  
 Если сочетание заданного семейства/стиля, <xref:System.Drawing.Font> создается с помощью этого и начертанием. Первый аргумент, переданный <xref:System.Drawing.Font.%23ctor%2A> конструктор является имя семейства шрифтов (не <xref:System.Drawing.FontFamily> объекта, как в случае других вариантах <xref:System.Drawing.Font.%23ctor%2A> конструктор). После <xref:System.Drawing.Font> объект создан, он передается <xref:System.Drawing.Graphics.DrawString%2A> метод <xref:System.Drawing.Graphics> класса, чтобы отобразить имя семейства, а также имя стиля.  
  
 Выходные данные следующий код аналогичен результат, показанный на следующем рисунке:  
  
 ![Снимок экрана: текст в различные шрифты.](./media/how-to-create-a-private-font-collection/various-fonts-text-output.png)  
  
 Arial.tff (который был добавлен в частную коллекцию шрифтов в следующем примере кода) — это файл шрифта Arial обычного стиля. Обратите внимание, что выходные данные программы показано несколько доступные стили, кроме обычных шрифт Arial семейства. Это потому, что [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] может имитировать полужирный, курсив и полужирный курсив обычного начертания. [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] Можно также создавать, зачеркивание и подчеркивание обычного начертания.  
  
 Аналогичным образом [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] можно имитировать полужирным курсивом стиль из полужирный стиль или курсивное начертание. Выходные данные программы показано, что полужирным курсивом стиля для семейства раз несмотря на то, что TimesBd.tff (Times New Roman, полужирный) является единственным файлом раз в коллекции.  
  
 [!code-csharp[System.Drawing.FontsAndText#51](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.FontsAndText/CS/Class1.cs#51)]
 [!code-vb[System.Drawing.FontsAndText#51](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.FontsAndText/VB/Class1.vb#51)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.PaintEventHandler>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Text.PrivateFontCollection>
- [Шрифты и текст](using-fonts-and-text.md)
