---
title: Практическое руководство. Установка значения, отображаемого c помощью элемента управления ProgressBar в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ProgressBar control [Windows Forms], setting value displayed
- progress controls [Windows Forms], setting value displayed
ms.assetid: 0e5010ad-1e9a-4271-895e-5a3d24d37a26
ms.openlocfilehash: 42a9e0f67f00c1a706b72ab0eeb522e99d8a8dfe
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59300480"
---
# <a name="how-to-set-the-value-displayed-by-the-windows-forms-progressbar-control"></a>Практическое руководство. Установка значения, отображаемого c помощью элемента управления ProgressBar в Windows Forms
> [!IMPORTANT]
>  Элемент управления <xref:System.Windows.Forms.ToolStripProgressBar> заменяет элемент управления <xref:System.Windows.Forms.ProgressBar> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.ProgressBar> можно сохранить для обратной совместимости и использования в будущем.  
  
 .NET Framework Предоставляет несколько способов для отображения значения, заданного в <xref:System.Windows.Forms.ProgressBar> элемента управления. Какой подход вы выберете будет зависеть от поставленной задачи или проблема, которую вы пытаетесь решить. В следующей таблице показаны подходы, доступные для выбора.  
  
|Подход|Описание|  
|--------------|-----------------|  
|Установите для параметра <xref:System.Windows.Forms.ProgressBar> напрямую управлять.|Этот подход полезен для выполнения задач, когда вы знаете общее количество элементов, используемых, например, при считывании записей из источника данных. Кроме того Если требуется только один или два раза значение, это простой способ сделать это. Используйте этот процесс и, наконец, в том случае, если необходимо уменьшить значение, отображаемое по индикатор хода выполнения.|  
|Увеличить <xref:System.Windows.Forms.ProgressBar> отображения фиксированным значением.|Этот подход полезен при отображении простой счетчик между минимальной и максимальной, такие как время, затраченное или количество файлов, которые были обработаны из известного общего.|  
|Увеличить <xref:System.Windows.Forms.ProgressBar> отображения, значение которого изменяется.|Этот подход полезен в тех случаях, когда вам нужно изменить отображаемое значение несколько раз в разных суммы. Пример будет отображаться объем места на жестком диске, использованное при записи набора файлов на диск.|  
  
 — Самый простой способ задать значение, отображаемое индикатором, задав <xref:System.Windows.Forms.ProgressBar.Value%2A> свойство. Это можно сделать во время разработки или во время выполнения.  
  
### <a name="to-set-the-progressbar-value-directly"></a>Чтобы задать значение элемента управления ProgressBar напрямую  
  
1. Задайте <xref:System.Windows.Forms.ProgressBar> элемента управления <xref:System.Windows.Forms.ProgressBar.Minimum%2A> и <xref:System.Windows.Forms.ProgressBar.Maximum%2A> значения.  
  
2. В коде, задайте в качестве <xref:System.Windows.Forms.ProgressBar.Value%2A> свойство в целочисленное значение между минимальным и максимальным значениями установки.  
  
    > [!NOTE]
    >  Если задать <xref:System.Windows.Forms.ProgressBar.Value%2A> свойство за пределами диапазона, установленного <xref:System.Windows.Forms.ProgressBar.Minimum%2A> и <xref:System.Windows.Forms.ProgressBar.Maximum%2A> свойства, элемент управления создает <xref:System.ArgumentException> исключение.  
  
     В следующем примере кода показано задание <xref:System.Windows.Forms.ProgressBar> значение напрямую. Код считывает записи из источника данных и обновляет индикатор хода выполнения и метки, каждый раз при считывании записи данных. В этом примере требуется, что форма содержит <xref:System.Windows.Forms.Label> управления <xref:System.Windows.Forms.ProgressBar> управления и таблицы данных со строкой `CustomerRow` с `FirstName` и `LastName` поля.  
  
    ```vb  
    Public Sub CreateNewRecords()  
       ' Sets the progress bar's Maximum property to  
       ' the total number of records to be created.  
       ProgressBar1.Maximum = 20  
  
       ' Creates a new record in the dataset.  
       ' NOTE: The code below will not compile, it merely  
       ' illustrates how the progress bar would be used.  
       Dim anyRow As CustomerRow = DatasetName.ExistingTable.NewRow  
       anyRow.FirstName = "Stephen"  
       anyRow.LastName = "James"  
       ExistingTable.Rows.Add(anyRow)  
  
       ' Increases the value displayed by the progress bar.  
       ProgressBar1.Value += 1  
       ' Updates the label to show that a record was read.  
       Label1.Text = "Records Read = " & ProgressBar1.Value.ToString()  
    End Sub  
    ```  
  
    ```csharp  
    public void createNewRecords()  
    {  
       // Sets the progress bar's Maximum property to  
       // the total number of records to be created.  
       progressBar1.Maximum = 20;  
  
       // Creates a new record in the dataset.  
       // NOTE: The code below will not compile, it merely  
       // illustrates how the progress bar would be used.  
       CustomerRow anyRow = DatasetName.ExistingTable.NewRow();  
       anyRow.FirstName = "Stephen";  
       anyRow.LastName = "James";  
       ExistingTable.Rows.Add(anyRow);  
  
       // Increases the value displayed by the progress bar.  
       progressBar1.Value += 1;  
       // Updates the label to show that a record was read.  
       label1.Text = "Records Read = " + progressBar1.Value.ToString();  
    }  
    ```  
  
     При отображении хода выполнения, который увеличивается с фиксированным интервалом, можно задать значение и затем вызвать метод, увеличивающий <xref:System.Windows.Forms.ProgressBar> элемента управления значение этого интервала. Это полезно для таймеров и других сценариев, где вы не измеряете хода выполнения в процентах от целого.  
  
### <a name="to-increase-the-progress-bar-by-a-fixed-value"></a>Для увеличения индикатора хода выполнения на фиксированную величину  
  
1. Задайте <xref:System.Windows.Forms.ProgressBar> элемента управления <xref:System.Windows.Forms.ProgressBar.Minimum%2A> и <xref:System.Windows.Forms.ProgressBar.Maximum%2A> значения.  
  
2. Задайте в качестве <xref:System.Windows.Forms.ProgressBar.Step%2A> свойство в целое число, представляющее сумму для увеличения индикатора хода выполнения отображается значение.  
  
3. Вызовите <xref:System.Windows.Forms.ProgressBar.PerformStep%2A> метод, чтобы изменить значения, отображаемого в, заданного параметром <xref:System.Windows.Forms.ProgressBar.Step%2A> свойство.  
  
     В следующем примере кода показано, как индикатор хода выполнения обеспечить число файлов в ходе операции копирования.  
  
     В следующем примере так как каждый файл считывается в память, индикатор хода выполнения и метка они обновлены в соответствии считывания на общее количество файлов. В этом примере требуется, что форма содержит <xref:System.Windows.Forms.Label> управления и <xref:System.Windows.Forms.ProgressBar> элемента управления.  
  
    ```vb  
    Public Sub LoadFiles()  
       ' Sets the progress bar's minimum value to a number representing  
       ' no operations complete -- in this case, no files read.  
       ProgressBar1.Minimum = 0  
       ' Sets the progress bar's maximum value to a number representing  
       ' all operations complete -- in this case, all five files read.  
       ProgressBar1.Maximum = 5  
       ' Sets the Step property to amount to increase with each iteration.  
       ' In this case, it will increase by one with every file read.  
       ProgressBar1.Step = 1  
  
       ' Dimensions a counter variable.  
       Dim i As Integer  
       ' Uses a For...Next loop to iterate through the operations to be  
       ' completed. In this case, five files are to be copied into memory,  
       ' so the loop will execute 5 times.  
       For i = 0 To 4  
          ' Insert code to copy a file  
          ProgressBar1.PerformStep()  
          ' Update the label to show that a file was read.  
          Label1.Text = "# of Files Read = " & ProgressBar1.Value.ToString  
       Next i  
    End Sub  
    ```  
  
    ```csharp  
    public void loadFiles()  
    {  
       // Sets the progress bar's minimum value to a number representing  
       // no operations complete -- in this case, no files read.  
       progressBar1.Minimum = 0;  
       // Sets the progress bar's maximum value to a number representing  
       // all operations complete -- in this case, all five files read.  
       progressBar1.Maximum = 5;  
       // Sets the Step property to amount to increase with each iteration.  
       // In this case, it will increase by one with every file read.  
       progressBar1.Step = 1;  
  
       // Uses a for loop to iterate through the operations to be  
       // completed. In this case, five files are to be copied into memory,  
       // so the loop will execute 5 times.  
       for (int i = 0; i <= 4; i++)  
       {  
          // Inserts code to copy a file  
          progressBar1.PerformStep();  
          // Updates the label to show that a file was read.  
          label1.Text = "# of Files Read = " + progressBar1.Value.ToString();  
       }  
    }  
    ```  
  
     Наконец можно увеличить значения, отображенного на индикатор хода выполнения, таким образом, чтобы каждое увеличение уникальным числом. Это полезно в тех случаях, когда вы отслеживает ряд уникальных операций, таких как запись файлов разных размеров на жесткий диск или измерение хода выполнения в процентах от целого.  
  
### <a name="to-increase-the-progress-bar-by-a-dynamic-value"></a>Чтобы увеличить индикатор хода выполнения на динамическое значение  
  
1. Задайте <xref:System.Windows.Forms.ProgressBar> элемента управления <xref:System.Windows.Forms.ProgressBar.Minimum%2A> и <xref:System.Windows.Forms.ProgressBar.Maximum%2A> значения.  
  
2. Вызовите <xref:System.Windows.Forms.ProgressBar.Increment%2A> метод, чтобы изменить значения, отображаемого в целое число, указываемое.  
  
     В следующем примере кода показано, как индикатор хода выполнения можно рассчитать, объем дискового пространства, использованного в ходе операции копирования.  
  
     В следующем примере так как каждый файл записывается на жесткий диск, индикатор хода выполнения и метка они обновлены в соответствии объем места на жестком диске. В этом примере требуется, что форма содержит <xref:System.Windows.Forms.Label> управления и <xref:System.Windows.Forms.ProgressBar> элемента управления.  
  
    ```vb  
    Public Sub ReadFiles()  
       ' Sets the progress bar's minimum value to a number   
       ' representing the hard disk space before the files are read in.  
       ' You will most likely have to set this using a system call.  
       ' NOTE: The code below is meant to be an example and  
       ' will not compile.  
       ProgressBar1.Minimum = AvailableDiskSpace()  
       ' Sets the progress bar's maximum value to a number   
       ' representing the total hard disk space.  
       ' You will most likely have to set this using a system call.  
       ' NOTE: The code below is meant to be an example   
       ' and will not compile.  
       ProgressBar1.Maximum = TotalDiskSpace()  
  
       ' Dimension a counter variable.  
       Dim i As Integer  
       ' Uses a For...Next loop to iterate through the operations to be  
       ' completed. In this case, five files are to be written to the disk,  
       ' so it will execute the loop 5 times.  
       For i = 1 To 5  
          ' Insert code to read a file into memory and update file size.  
          ' Increases the progress bar's value based on the size of   
          ' the file currently being written.  
          ProgressBar1.Increment(FileSize)  
          ' Updates the label to show available drive space.  
          Label1.Text = "Current Disk Space Used = " &_   
          ProgressBar1.Value.ToString()  
       Next i  
    End Sub  
    ```  
  
    ```csharp  
    public void readFiles()  
    {  
       // Sets the progress bar's minimum value to a number   
       // representing the hard disk space before the files are read in.  
       // You will most likely have to set this using a system call.  
       // NOTE: The code below is meant to be an example and   
       // will not compile.  
       progressBar1.Minimum = AvailableDiskSpace();  
       // Sets the progress bar's maximum value to a number   
       // representing the total hard disk space.  
       // You will most likely have to set this using a system call.  
       // NOTE: The code below is meant to be an example   
       // and will not compile.  
       progressBar1.Maximum = TotalDiskSpace();  
  
       // Uses a for loop to iterate through the operations to be  
       // completed. In this case, five files are to be written  
       // to the disk, so it will execute the loop 5 times.  
       for (int i = 1; i<= 5; i++)  
       {  
          // Insert code to read a file into memory and update file size.  
          // Increases the progress bar's value based on the size of   
          // the file currently being written.  
          progressBar1.Increment(FileSize);  
          // Updates the label to show available drive space.  
          label1.Text = "Current Disk Space Used = " + progressBar1.Value.ToString();  
       }  
    }  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ProgressBar>
- <xref:System.Windows.Forms.ToolStripProgressBar>
- [Общие сведения об элементе управления ProgressBar](progressbar-control-overview-windows-forms.md)
- [Элемент управления ProgressBar](progressbar-control-windows-forms.md)
