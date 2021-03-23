---
title: Практическое руководство. Определение установленной версии WPF
ms.date: 03/30/2017
helpviewer_keywords:
- version [WPF], finding
ms.assetid: 99971cef-e218-4f9f-a4c1-350332741860
ms.openlocfilehash: ffbd9a4c7f66dff9c8773dff4259551e20aa963d
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59305680"
---
# <a name="how-to-determine-the-installed-version-of-wpf"></a>Практическое руководство. Определение установленной версии WPF
Номер версии для текущей установленной версии [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] находится в **реестра**.  
  
 Чтобы найти номер версии:  
  
1. В меню **Пуск** выберите пункт **Выполнить**.  
  
2. В **откройте**, тип **regedit.exe**.  
  
3. Откройте следующий раздел:  
  
 `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.0\Setup\Windows Presentation Foundation`  
  
 WPF Номер версии хранится в **версии** значение.
