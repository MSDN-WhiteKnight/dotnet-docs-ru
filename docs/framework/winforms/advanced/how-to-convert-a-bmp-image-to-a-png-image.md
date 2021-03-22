---
title: Практическое руководство. Преобразование изображение из формата BMP в формат PNG
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- BMP images [Windows Forms], converting to PNG
- image formats [Windows Forms], converting between
ms.assetid: 9d4a692d-73ac-4ce3-9e05-9ec321e8fbd6
ms.openlocfilehash: 3072c07781a8e8e57b64b48e5b4c304c2a0a0efb
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59217020"
---
# <a name="how-to-convert-a-bmp-image-to-a-png-image"></a>Практическое руководство. Преобразование изображение из формата BMP в формат PNG
Очень часто необходимо преобразовать изображение из одного формата в другой. Это легко сделать, вызвав метод <xref:System.Drawing.Image.Save%2A> класса <xref:System.Drawing.Image> и указав в качестве параметра <xref:System.Drawing.Imaging.ImageFormat> нужный формат файла.  
  
## <a name="example"></a>Пример  
 В примере ниже изображение в формате BMP загружается из типа и сохраняется в формате PNG.  
  
 [!code-csharp[UsingImageEncodersDecoders#4](~/samples/snippets/csharp/VS_Snippets_Winforms/UsingImageEncodersDecoders/CS/Form1.cs#4)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   приложение Windows Forms;  
  
-   ссылка на пространство имен `System.Drawing.Imaging`.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Получение списка установленных кодировщиков](how-to-list-installed-encoders.md)
- [Применение кодировщиков и декодеров изображений в управляемом GDI+](using-image-encoders-and-decoders-in-managed-gdi.md)
- [Типы точечных рисунков](types-of-bitmaps.md)
