---
description: См. Дополнительные сведения о примерах КУРСОРа REF
title: Примеры REF CURSOR
ms.date: 03/30/2017
ms.assetid: c257da03-c6c9-4cf8-b591-b7740a962c40
ms.openlocfilehash: e7cb411778b325400d37511b082032e590b339c0
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99773229"
---
# <a name="ref-cursor-examples"></a>Примеры REF CURSOR

Примеры REF CURSOR состоят из трех следующих примеров Microsoft Visual Basic, в которых демонстрируется использование REF CURSOR.  
  
|Образец|Описание|  
|------------|-----------------|  
|[Параметры REF CURSOR в объекте OracleDataReader](ref-cursor-parameters-in-an-oracledatareader.md)|В этом примере выполняется хранимая процедура PL/SQL, которая возвращает параметр REF CURSOR и считывает значение через <xref:System.Data.OracleClient.OracleDataReader>.|  
|[Извлечение данных нескольких REF CURSOR с использованием OracleDataReader](retrieving-data-from-multiple-ref-cursors.md)|В этом примере выполняется хранимая процедура PL/SQL, которая возвращает два параметра REF CURSOR и считывает значения с помощью **OracleDataReader**.|  
|[Заполнение набора данных с помощью одного или нескольких параметров REF CURSOR](filling-a-dataset-using-one-or-more-ref-cursors.md)|В этом примере выполняется хранимая процедура PL/SQL, которая возвращает два параметра REF CURSOR и заполняет набор <xref:System.Data.DataSet> возвращенными строками.|  
  
 Чтобы использовать эти примеры, может потребоваться создать таблицы Oracle; кроме того, необходимо создать пакет и текст пакета PL/SQL.  
  
## <a name="creating-the-oracle-tables"></a>Создание таблиц Oracle  

 В этих примерах используются таблицы, которые определены в схеме Oracle Scott/Tiger. Схема Oracle Scott/Tiger имеется в большинстве установок Oracle. Если этой схемы не существует, чтобы создать таблицы и индексы для этих примеров, можно использовать командный файл SQL в {OracleHome}\rdbms\admin\scott.sql.  
  
## <a name="creating-the-oracle-package-and-package-body"></a>Создание пакета и текста пакета Oracle  

 Для этих примеров требуется наличие на вашем сервере следующих пакетов и текста пакета PL/SQL. Создайте на сервере Oracle следующий пакет Oracle.  
  
```sql
CREATE OR REPLACE PACKAGE CURSPKG AS
    TYPE T_CURSOR IS REF CURSOR;
    PROCEDURE OPEN_ONE_CURSOR (N_EMPNO IN NUMBER,
                               IO_CURSOR IN OUT T_CURSOR);
    PROCEDURE OPEN_TWO_CURSORS (EMPCURSOR OUT T_CURSOR,
                                DEPTCURSOR OUT T_CURSOR);  
END CURSPKG;  
/
```  
  
 На сервере Oracle создайте следующий текст пакета Oracle.  
  
```sql
CREATE OR REPLACE PACKAGE BODY CURSPKG AS  
    PROCEDURE OPEN_ONE_CURSOR (N_EMPNO IN NUMBER,  
                               IO_CURSOR IN OUT T_CURSOR)  
    IS
        V_CURSOR T_CURSOR;
    BEGIN
        IF N_EMPNO <> 0
        THEN  
             OPEN V_CURSOR FOR
             SELECT EMP.EMPNO, EMP.ENAME, DEPT.DEPTNO, DEPT.DNAME
                  FROM EMP, DEPT
                  WHERE EMP.DEPTNO = DEPT.DEPTNO
                  AND EMP.EMPNO = N_EMPNO;  
  
        ELSE
             OPEN V_CURSOR FOR
             SELECT EMP.EMPNO, EMP.ENAME, DEPT.DEPTNO, DEPT.DNAME
                  FROM EMP, DEPT
                  WHERE EMP.DEPTNO = DEPT.DEPTNO;  
  
        END IF;  
        IO_CURSOR := V_CURSOR;
    END OPEN_ONE_CURSOR;
  
    PROCEDURE OPEN_TWO_CURSORS (EMPCURSOR OUT T_CURSOR,  
                                DEPTCURSOR OUT T_CURSOR)  
    IS
        V_CURSOR1 T_CURSOR;
        V_CURSOR2 T_CURSOR;
    BEGIN
        OPEN V_CURSOR1 FOR SELECT * FROM EMP;  
        OPEN V_CURSOR2 FOR SELECT * FROM DEPT;  
        EMPCURSOR  := V_CURSOR1;
        DEPTCURSOR := V_CURSOR2;
    END OPEN_TWO_CURSORS;
END CURSPKG;  
/  
```  
  
## <a name="see-also"></a>См. также

- [REF CURSOR в Oracle](oracle-ref-cursors.md)
- [Общие сведения об ADO.NET](ado-net-overview.md)
