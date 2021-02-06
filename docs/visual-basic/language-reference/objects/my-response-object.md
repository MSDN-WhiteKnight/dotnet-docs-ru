---
description: 'Дополнительные сведения о: объект My. Response'
title: Объект My.Response
ms.date: 07/20/2015
f1_keywords:
- My.MyWebExtension.Response
- My.Response
helpviewer_keywords:
- My.Response object
ms.assetid: 626359bc-3165-40b4-bfaf-2c610e26eb5b
ms.openlocfilehash: 551528356040539994251cb66a905d0249f482da
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99640619"
---
# <a name="myresponse-object"></a>Объект My.Response

Возвращает <xref:System.Web.HttpResponse> объект, связанный с объектом <xref:System.Web.UI.Page> . Этот объект позволяет отправлять клиенту данные HTTP-ответа и содержит сведения об этом ответе.  
  
## <a name="remarks"></a>Remarks  

 `My.Response`Объект содержит текущий объект, <xref:System.Web.HttpResponse> связанный со страницей.  
  
 `My.Response`Объект доступен только для приложений ASP.NET.  
  
## <a name="example"></a>Пример  

 Следующий пример получает коллекцию заголовков из `My.Request` объекта и использует `My.Response` объект для записи на страницу ASP.NET.  
  
 [!code-aspx-vb[VbVbalrMyWeb#1](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrMyWeb/VB/Default.aspx#1)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Web.HttpResponse>
- [Объект My.Request](my-request-object.md)
