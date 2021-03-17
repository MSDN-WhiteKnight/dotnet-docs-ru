---
title: Практическое руководство. Управление буферизацией графики вручную
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- flicker [Windows Forms], reducing by manually managing graphics
- graphics [Windows Forms], managing buffered
ms.assetid: 4c2a90ee-bbbe-4ff6-9170-1b06c195c918
ms.openlocfilehash: 965e3225f8cf1af6d61b81434089ebacac8ad13a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59138675"
---
# <a name="how-to-manually-manage-buffered-graphics"></a>Практическое руководство. Управление буферизацией графики вручную
Для более сложных сценариях буферизации, можно использовать [!INCLUDE[dnprdnshort](../../../../includes/dnprdnshort-md.md)] классы для реализации собственной логики двойной буферизации. Класс, отвечающий за выделение и управление ими отдельных буферов графики является <xref:System.Drawing.BufferedGraphicsContext> класса. Каждое приложение имеет свои собственные значения по умолчанию <xref:System.Drawing.BufferedGraphicsContext> , управляет всеми двойную буферизацию для этого приложения. Ссылка на этот экземпляр можно получить, вызвав <xref:System.Drawing.BufferedGraphicsManager.Current%2A>.  
  
### <a name="to-obtain-a-reference-to-the-default-bufferedgraphicscontext"></a>Для получения ссылки на значение по умолчанию BufferedGraphicsContext  
  
-   Задать <xref:System.Drawing.BufferedGraphicsManager.Current%2A> свойства, как показано в следующем примере кода.  
  
     [!code-csharp[System.Windows.Forms.LegacyBufferedGraphics#11](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.LegacyBufferedGraphics/CS/Class1.cs#11)]
     [!code-vb[System.Windows.Forms.LegacyBufferedGraphics#11](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.LegacyBufferedGraphics/VB/Class1.vb#11)]  
  
    > [!NOTE]
    >  Необходимо вызвать `Dispose` метод <xref:System.Drawing.BufferedGraphicsContext> ссылку, полученное от <xref:System.Drawing.BufferedGraphicsManager> класса. <xref:System.Drawing.BufferedGraphicsManager> Обрабатывает все выделения памяти и распространения по умолчанию <xref:System.Drawing.BufferedGraphicsContext> экземпляров.  
  
     Для насыщенных графикой приложений, таких как анимации, может иногда повысить производительность с помощью специальной <xref:System.Drawing.BufferedGraphicsContext> вместо <xref:System.Drawing.BufferedGraphicsContext> предоставляемые <xref:System.Drawing.BufferedGraphicsManager>. Это позволяет создавать и управлять ими буферы графики по отдельности, без несения издержек производительности управления все другие буферизованной графики для вашего приложения на то, что память, занятая приложения будет больше.  
  
### <a name="to-create-a-dedicated-bufferedgraphicscontext"></a>Чтобы создать выделенный BufferedGraphicsContext  
  
-   Объявите и создайте новый экземпляр класса <xref:System.Drawing.BufferedGraphicsContext> класса, как показано в следующем примере кода.  
  
     [!code-csharp[System.Windows.Forms.LegacyBufferedGraphics#12](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.LegacyBufferedGraphics/CS/Class1.cs#12)]
     [!code-vb[System.Windows.Forms.LegacyBufferedGraphics#12](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.LegacyBufferedGraphics/VB/Class1.vb#12)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.BufferedGraphicsContext>
- [Двойная буферизация графики](double-buffered-graphics.md)
- [Практическое руководство. Отрисовка буферизированной графики вручную](how-to-manually-render-buffered-graphics.md)
