---
title: Транзакции
ms.date: 12/13/2019
description: Узнайте, как использовать транзакции.
ms.openlocfilehash: 4b72a1573a560ffd1bfd0f54d46ab3b135280976
ms.sourcegitcommit: 30a558d23e3ac5a52071121a52c305c85fe15726
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 12/25/2019
ms.locfileid: "75450384"
---
# <a name="transactions"></a>Транзакции

Транзакции позволяют сгруппировать несколько инструкций SQL в одну единицу работы, которая зафиксирована в базе данных как одна атомарная единица. При сбое любой инструкции в транзакции можно выполнить откат изменений, выполненных предыдущими инструкциями. Начальное состояние базы данных при запуске транзакции сохраняется. Использование транзакции может также повысить производительность SQLite при одновременном внесении многочисленных изменений в базу данных.

## <a name="concurrency"></a>параллелизм

В SQLite только одна транзакция может одновременно иметь изменения, ожидающие в базе данных. В связи с этим вызовы <xref:Microsoft.Data.Sqlite.SqliteConnection.BeginTransaction%2A> и методы `Execute` в <xref:Microsoft.Data.Sqlite.SqliteCommand> могут исполняться, если другая транзакция занимает слишком много времени.

Дополнительные сведения о блокировках, повторных попытках и времени ожидания см. в разделе [ошибки базы данных](database-errors.md).

## <a name="isolation-levels"></a>Уровни изоляции

Транзакции по умолчанию **сериализуются** в SQLite. Этот уровень изоляции гарантирует, что любые изменения, внесенные в транзакцию, будут полностью изолированы. Изменения транзакции не затрагивают другие инструкции, выполняемые за пределами транзакции.

SQLite также поддерживает **Незафиксированное чтение** при использовании общего кэша. Этот уровень позволяет читать "грязные", неповторяемые операции чтения и фантомы:

- « *Грязное» чтение* происходит, когда запрос возвращает изменения, ожидающие в одной транзакции, но при этом выполняется откат изменений в транзакции. Результаты содержат данные, которые никогда не зафиксировались в базе данных.

- *Неповторяемое чтение* происходит, когда транзакция запрашивает одну и ту же строку дважды, но результаты различаются, так как они были изменены между двумя запросами другой транзакцией.

- *Фантомы* — это строки, которые изменяются или добавляются в соответствии с предложением WHERE запроса во время транзакции. Если разрешено, то один и тот же запрос может возвращать разные строки при двойном выполнении в одной транзакции.

Microsoft. Data. SQLite рассматривает IsolationLevel, переданные в <xref:Microsoft.Data.Sqlite.SqliteConnection.BeginTransaction%2A> как минимальный уровень. Фактический уровень изоляции будет повышен до уровня READ UNCOMMITTED или Serializable.

Следующий код имитирует «грязное» чтение. Обратите внимание, что строка подключения должна включать `Cache=Shared`.

[!code-csharp[](../../../../samples/snippets/standard/data/sqlite/DirtyReadSample/Program.cs?name=snippet_DirtyRead)]