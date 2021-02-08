---
description: Дополнительные сведения см. в статье как создать настраиваемый код путем изменения DBML-файла.
title: Практическое руководство. Как генерировать настраиваемый код путем изменения DBML-файла
ms.date: 03/30/2017
ms.assetid: 50ad597a-8598-42d3-82dd-fc7d702ebc37
ms.openlocfilehash: 0dd4024b3f6a0ca0583de6bfbdb7463fab14d969
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99786008"
---
# <a name="how-to-generate-customized-code-by-modifying-a-dbml-file"></a>Практическое руководство. Как генерировать настраиваемый код путем изменения DBML-файла

Исходный код Visual Basic или C# можно создать из файла метаданных на языке разметки базы данных (. DBML). Этот способ предоставляет возможность настройки заданного по умолчанию DBML-файла до создания кода сопоставления приложений. Данная возможность является дополнительной.  
  
 Ниже указаны действия, необходимые для выполнения данного процесса.  
  
1. Создайте DBML-файл.  
  
2. Для изменения DBML-файла используйте редактор. Обратите внимание, что DBML-файл должен проверяться на соответствие файлу определения схемы (XSD) [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] файлам. dbml. Дополнительные сведения см. [в разделе Создание кода в LINQ to SQL](code-generation-in-linq-to-sql.md).  
  
3. Создайте исходный код Visual Basic или C#.  
  
 В следующих примерах используется средства командной строки SQLMetal. Дополнительные сведения см. в разделе [SQLMetal.exe (средство создания кода)](../../../../tools/sqlmetal-exe-code-generation-tool.md).  
  
## <a name="example"></a>Пример  

 В следующем коде DBML-файл создается из учебной базы данных "Northwind". В качестве источника метаданных база данных можно использовать либо имя базы данных, либо имя MDF-файла.  
  
```console  
sqlmetal /server:myserver /database:northwind /dbml:mymeta.dbml  
sqlmetal /dbml:mymeta.dbml mydbfile.mdf  
```  
  
## <a name="example"></a>Пример  

 Следующий код создает Visual Basic или файл исходного кода C# из DBML-файла.  
  
```console
sqlmetal /namespace:nwind /code:nwind.vb /language:vb DBMLFile.dbml  
sqlmetal /namespace:nwind /code:nwind.cs /language:csharp DBMLFile.dbml  
```  
  
## <a name="see-also"></a>См. также

- [Создание кода в LINQ to SQL](code-generation-in-linq-to-sql.md)
- [SqlMetal.exe (средство создания кода)](../../../../tools/sqlmetal-exe-code-generation-tool.md)
- [Создание модели объектов](creating-the-object-model.md)
