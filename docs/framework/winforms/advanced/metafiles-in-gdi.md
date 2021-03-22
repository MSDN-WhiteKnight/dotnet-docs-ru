---
title: Метафайлы в GDI+
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- images [Windows Forms], metafiles
- GDI+, metafiles
- metafiles
ms.assetid: 51da872c-c783-440f-8bf6-1e580a966c31
ms.openlocfilehash: bb972f158496192aa38f10564209bb2781837414
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59119864"
---
# <a name="metafiles-in-gdi"></a>Метафайлы в GDI+
[!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] предоставляет <xref:System.Drawing.Imaging.Metafile> таким образом, чтобы можно было записывать и отображать метафайлы. Метафайл, также называемый векторного изображения, — это образ, который хранится в виде последовательности команд и параметров рисования. Команды и параметры, сохраненные в <xref:System.Drawing.Imaging.Metafile> объекта можно хранить в памяти или сохранить файл или поток.  
  
## <a name="metafile-formats"></a>Метафайлы  
 [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] позволяет отображать метафайлы, сохраненные в следующих форматах:  
  
-   Метафайл Windows (WMF)  
  
-   EMF (Enhanced Metafile —расширенный метафайл)  
  
-   EMF +  
  
 [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] позволяет сохранять метафайлы в форматы EMF и EMF +, но не в формате WMF.  
  
 EMF + является расширением формата EMF, [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] записи для сохранения. Существует две разновидности формат EMF +. EMF + только и EMF + Dual. Метафайлы EMF + Only содержат только [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] записей. Такие метафайлы могут отображаться путем [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] , но не по [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)]. Метафайлы EMF + Dual содержат [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] и [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] записей. Каждый [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] запись EMF + Dual метафайла, вместе с альтернативной [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] записи. Такие метафайлы могут отображаться путем [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] или [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)].  
  
 В следующем примере отображается метафайл, который был ранее сохранен как файл. Метафайл отображается с его верхнего левого угла в (100, 100).  
  
 [!code-csharp[System.Drawing.ImagesBitmapsMetafiles#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.ImagesBitmapsMetafiles/CS/Class1.cs#21)]
   
  
## <a name="see-also"></a>См. также

- [Работа с растровыми и векторными изображениями с использованием классов Image, Bitmap и Metafile](images-bitmaps-and-metafiles.md)
