---
title: Компонент BackgroundWorker
ms.date: 03/30/2017
helpviewer_keywords:
- BackgroundWorker component
- background tasks
- Asynchronous Pattern
- forms [Windows Forms], multithreading
- components [Windows Forms], asynchronous
- forms [Windows Forms], background operations
- threading [Windows Forms], background operations
- background operations
ms.assetid: bef7b0ab-ce57-475a-a2d6-fb8a702a9417
ms.openlocfilehash: 0baf54d27cf33eef7e4df7019ee98b42eba40205
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57710671"
---
# <a name="backgroundworker-component"></a>Компонент BackgroundWorker
`BackgroundWorker` Компонент позволяет форме или элементу управления выполнять операцию асинхронно.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Общие сведения о компоненте BackgroundWorker](backgroundworker-component-overview.md)  
 Описывает `BackgroundWorker` компонент, который дает возможность выполнять длительные операции асинхронно (в фоновом режиме»), в потоке, отличающемся от основного потока пользовательского интерфейса приложения.  
  
 [Пошаговое руководство: Выполнение операции в фоновом режиме](walkthrough-running-an-operation-in-the-background.md)  
 Демонстрирует использование `BackgroundWorker` компонента в конструкторе для выполнения длительной операции в отдельном потоке.  
  
 [Практическое руководство. Фоновое выполнение операции](how-to-run-an-operation-in-the-background.md)  
 Демонстрирует использование `BackgroundWorker` компонент для выполнения длительной операции в отдельном потоке.  
  
 [Пошаговое руководство: Реализация формы, в который выполняется фоновая операция](walkthrough-implementing-a-form-that-uses-a-background-operation.md)  
 Создание приложения с помощью конструктора, выполняющего математические вычисления в асинхронном режиме.  
  
 [Практическое руководство. Реализация формы, в которой выполняется фоновая операция](how-to-implement-a-form-that-uses-a-background-operation.md)  
 Создание приложения, выполняющего математические вычисления в асинхронном режиме.  
  
 [Практическое руководство. Загрузите файл в фоновом режиме](how-to-download-a-file-in-the-background.md)  
 Демонстрирует использование `BackgroundWorker` компонента для загрузки файла в отдельном потоке.  
  
## <a name="reference"></a>Ссылка  
 <xref:System.ComponentModel.BackgroundWorker>  
 Описание класса и всех его членов.  
  
 <xref:System.ComponentModel.RunWorkerCompletedEventArgs>  
 Описывает тип, содержащий данные для <xref:System.ComponentModel.BackgroundWorker.RunWorkerCompleted> событий.  
  
 <xref:System.ComponentModel.ProgressChangedEventArgs>  
 Описывает тип, содержащий данные для <xref:System.ComponentModel.BackgroundWorker.ProgressChanged> событий.  
  
## <a name="related-sections"></a>Связанные разделы  
 [Обзор асинхронной модели, основанной на событиях](../../../standard/asynchronous-programming-patterns/event-based-asynchronous-pattern-overview.md)  
 Описывает, как асинхронная модель позволяет использовать преимущества многопоточных приложений устраняет многие сложности, присущие многопоточности.
