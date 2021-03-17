---
title: GetCustomUI
ms.date: 03/30/2017
helpviewer_keywords:
- custom error messages [WPF]
ms.assetid: e55180fc-35bb-4f80-a136-772b5eb3e4e5
ms.openlocfilehash: 30084143949d2243fd310448c52e6b861505ad66
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59191254"
---
# <a name="getcustomui"></a>GetCustomUI
Вызывается программой PresentationHost.exe для получения пользовательских ход выполнения и сообщения об ошибках из узла, если реализовано.  
  
## <a name="syntax"></a>Синтаксис  
  
```  
HRESULT GetCustomUI( [out] BSTR* pwzProgressAssemblyName, [out] BSTR* pwzProgressClassName, [out] BSTR* pwzErrorAssemblyName, [out] BSTR* pwzErrorClassName );  
```  
  
## <a name="parameters"></a>Параметры  
 `pwzProgressAssemblyName`  
  
 [out] Указатель на сборку, содержащую пользовательский интерфейс хода выполнения, предоставляемую узла.  
  
 `pwzProgressClassName`  
  
 [out] Имя класса, пользовательском интерфейсе ход выполнения, предоставляемую узла предпочтительно [!INCLUDE[TLA#tla_titlexaml](../../../../includes/tlasharptla-titlexaml-md.md)] файл с <xref:System.Windows.Controls.Page> является его элемент верхнего уровня. Этот класс находится в сборке, который задается параметром `pwzProgressAssemblyName`.  
  
 `pwzErrorAssemblyName`  
  
 [out] Указатель на сборку, содержащую пользовательский интерфейс об узле.  
  
 `pwzErrorClassName`  
  
 [out] Имя класса, то есть пользователем узла об интерфейсе, предпочтительно файл XAML с <xref:System.Windows.Controls.Page> является его элемент верхнего уровня. Этот класс находится в сборке, который задается параметром `pwzErrorAssemblyName`.  
  
## <a name="property-valuereturn-value"></a>Значение свойства, возвращаемое значение  
 HRESULT: Не обрабатывается.  
  
## <a name="remarks"></a>Примечания  
 Ведущее приложение может иметь конкретной темы, могут не соответствовать PresentationHost.exe по умолчанию пользовательские интерфейсы. Если это так, можно реализовать ведущее приложение [GetCustomUI](getcustomui.md) для возврата ход выполнения и ошибки пользовательских интерфейсов PresentationHost.exe. PresentationHost.exe всегда будет вызывать [GetCustomUI](getcustomui.md) перед использованием его пользовательские интерфейсы по умолчанию.  
  
 Эта функция вызывается один раз во время инициализации процесс PresentationHost элемента.  
  
## <a name="see-also"></a>См. также

- [Интерфейс IWpfHostSupport](iwpfhostsupport.md)
