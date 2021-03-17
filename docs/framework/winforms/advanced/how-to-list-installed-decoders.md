---
title: Практическое руководство. Получение списка установленных декодеров
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- image codecs [Windows Forms], listing
- image decoders [Windows Forms], listing
ms.assetid: 11417191-8c95-40ca-8024-779e61706fb6
ms.openlocfilehash: c92b8010def2f77f859ee0bd9cdb1ed51dd15f27
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59079420"
---
# <a name="how-to-list-installed-decoders"></a>Практическое руководство. Получение списка установленных декодеров
Может потребоваться списке декодеров на компьютере, чтобы определить, является ли ваше приложение может считывать определенного файла формата изображений. <xref:System.Drawing.Imaging.ImageCodecInfo> Класс предоставляет <xref:System.Drawing.Imaging.ImageCodecInfo.GetImageDecoders%2A> статические методы, чтобы определить, какой образ декодеров доступны. <xref:System.Drawing.Imaging.ImageCodecInfo.GetImageDecoders%2A> Возвращает массив <xref:System.Drawing.Imaging.ImageCodecInfo> объектов.  
  
## <a name="example"></a>Пример  
 В следующем примере кода выводит список установленных декодеров и значения их свойств.  
  
 [!code-csharp[UsingImageEncodersDecoders#2](~/samples/snippets/csharp/VS_Snippets_Winforms/UsingImageEncodersDecoders/CS/Form1.cs#2)]
 [!code-vb[UsingImageEncodersDecoders#2](~/samples/snippets/visualbasic/VS_Snippets_Winforms/UsingImageEncodersDecoders/VB/Form1.vb#2)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   приложение Windows Forms;  
  
-   Объект <xref:System.Windows.Forms.PaintEventArgs>, который является параметром <xref:System.Windows.Forms.PaintEventHandler>.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Получение списка установленных кодировщиков](how-to-list-installed-encoders.md)
- [Применение кодировщиков и декодеров изображений в управляемом GDI+](using-image-encoders-and-decoders-in-managed-gdi.md)
