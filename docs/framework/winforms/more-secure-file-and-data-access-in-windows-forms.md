---
title: Более безопасный доступ к файлам и данным в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- security [Windows Forms], file access
- registry [Windows Forms]
- data access [Windows Forms]
- database access (Windows Forms security)
- data [Windows Forms], secure access
- file access [Windows Forms]
- security [Windows Forms], data access
ms.assetid: 3cd3e55b-2f5e-40dd-835d-f50f7ce08967
ms.openlocfilehash: 557c3296310a7eb3922a6c18b7b3de19ffac953c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59115769"
---
# <a name="more-secure-file-and-data-access-in-windows-forms"></a>Более безопасный доступ к файлам и данным в Windows Forms
В [!INCLUDE[dnprdnshort](../../../includes/dnprdnshort-md.md)] для защиты ресурсов и данных используются разрешения. То, какие данные может считывать или записывать приложение, зависит от предоставленных ему разрешений. Когда приложение работает в среде с частичным доверием, то доступ к данным может быть запрещен или может быть необходимо изменить способ доступа к данным.  
  
 При возникновении ограничения безопасности есть два варианта: подтверждение разрешения (при условии что оно было предоставлено приложению) или использование версии кода, созданной для работы в режиме частичного доверия. В следующих разделах рассматриваются способы доступа к файлам, базам данных и реестру из приложений, работающих в среде с частичным доверием.  
  
> [!NOTE]
>  По умолчанию средства, создающие развертывания [!INCLUDE[ndptecclick](../../../includes/ndptecclick-md.md)], требуют полного доверия от компьютеров, на которых они запущены. Если вы решите, хотите воспользоваться преимуществами повышения безопасности работы в режиме частичного доверия, необходимо изменить это значение по умолчанию в Visual Studio или в одном из [!INCLUDE[winsdklong](../../../includes/winsdklong-md.md)] средств (Mage.exe или MageUI.exe). Дополнительные сведения о безопасности Windows Forms и о том, как определить оптимальный уровень доверия для приложения, см. в разделе [безопасности в Windows Forms Overview](security-in-windows-forms-overview.md).  
  
## <a name="file-access"></a>Доступ к файлам  
 Класс <xref:System.Security.Permissions.FileIOPermission> контролирует доступ к файлам и папкам в [!INCLUDE[dnprdnshort](../../../includes/dnprdnshort-md.md)]. По умолчанию система безопасности не предоставляет разрешение <xref:System.Security.Permissions.FileIOPermission> в средах с частичным доверием, таких как зона локальной интрасети или Интернет. Однако приложение, которому требуется доступ к файлам, может работать в таких средах, если изменить структуру приложения или использовать другие методы доступа к файлам. По умолчанию зоне локальной интрасети предоставляется право на доступ к тому же сайту и к той же папке, на подключение к исходному сайту и чтение данных из папки установки. Приложениям в зоне Интернета по умолчанию разрешено подключаться только к исходному сайту.  
  
### <a name="user-specified-files"></a>Файлы, определенные пользователем  
 Один из способов решения проблемы, связанной с отсутствием доступа к файлам, — запросить у пользователя сведения о конкретном файле с помощью объекта <xref:System.Windows.Forms.OpenFileDialog> или <xref:System.Windows.Forms.SaveFileDialog>. Взаимодействие с пользователем помогает получить некоторую уверенность в том, что приложение не сможет несанкционированно загрузить личные файлы или перезаписать важные файлы. Методы <xref:System.Windows.Forms.OpenFileDialog.OpenFile%2A> и <xref:System.Windows.Forms.SaveFileDialog.OpenFile%2A> предоставляют доступ для чтения и записи файла, открывая файловый поток для файла, указанного пользователем. Эти методы также помогают защитить файл пользователя, скрывая путь к файлу.  
  
> [!NOTE]
>  Эти разрешения зависят от того, в какой зоне находится приложение: интрасеть или Интернет. Приложения зоны Интернета могут использовать только класс <xref:System.Windows.Forms.OpenFileDialog>, тогда как приложения интрасети имеют неограниченное разрешение на использование файловых диалоговых окон.  
  
 Класс <xref:System.Security.Permissions.FileDialogPermission> указывает, какой тип файлового диалогового окна может использовать приложение. В таблице ниже показаны значения, которые необходимо использовать для каждого класса <xref:System.Windows.Forms.FileDialog>.  
  
|Класс|Необходимое значение для доступа|  
|-----------|---------------------------|  
|<xref:System.Windows.Forms.OpenFileDialog>|<xref:System.Security.Permissions.FileDialogPermissionAccess.Open>|  
|<xref:System.Windows.Forms.SaveFileDialog>|<xref:System.Security.Permissions.FileDialogPermissionAccess.Save>|  
  
> [!NOTE]
>  Конкретные разрешения не запрашиваются до тех пор, пока не будет вызван метод <xref:System.Windows.Forms.OpenFileDialog.OpenFile%2A>.  
  
 Разрешение на вывод файлового диалогового окна не дает приложению полный доступ ко всем членам классов <xref:System.Windows.Forms.FileDialog>, <xref:System.Windows.Forms.OpenFileDialog> и <xref:System.Windows.Forms.SaveFileDialog>. Точные разрешения, необходимые для вызова каждого метода, представлены в справочном разделе по этому методу в документации по библиотеке классов [!INCLUDE[dnprdnshort](../../../includes/dnprdnshort-md.md)].  
  
 В примере кода ниже метод <xref:System.Windows.Forms.OpenFileDialog.OpenFile%2A> используется для открытия указанного пользователем файла в элементе управления <xref:System.Windows.Forms.RichTextBox>. Для этого требуется разрешение <xref:System.Security.Permissions.FileDialogPermission> и связанное с ним значение перечисления <xref:System.Security.Permissions.FileDialogPermissionAttribute.Open%2A>. В примере показано, как обрабатывать исключение <xref:System.Security.SecurityException> для определения того, нужно ли отключить возможность сохранения. В этом примере требуется, чтобы форма <xref:System.Windows.Forms.Form> содержала элемент управления <xref:System.Windows.Forms.Button> с именем `ButtonOpen` и элемент управления <xref:System.Windows.Forms.RichTextBox> с именем `RtfBoxMain`.  
  
> [!NOTE]
>  Программная логика для возможности сохранения в примере не представлена.  
  
```vb  
Private Sub ButtonOpen_Click(ByVal sender As System.Object, _  
    ByVal e As System.EventArgs) Handles ButtonOpen.Click   
  
    Dim editingFileName as String = ""  
    Dim saveAllowed As Boolean = True  
  
    ' Displays the OpenFileDialog.  
    If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then  
        Dim userStream as System.IO.Stream  
        Try   
            ' Opens the file stream for the file selected by the user.  
            userStream =OpenFileDialog1.OpenFile()   
            Me.RtfBoxMain.LoadFile(userStream, _  
                RichTextBoxStreamType.PlainText)  
        Finally  
            userStream.Close()  
        End Try  
  
        ' Tries to get the file name selected by the user.  
        ' Failure means that the application does not have  
        ' unrestricted permission to the file.  
        Try   
            editingFileName = OpenFileDialog1.FileName  
        Catch ex As Exception  
            If TypeOf ex Is System.Security.SecurityException Then   
                ' The application does not have unrestricted permission   
                ' to the file so the save feature will be disabled.  
                saveAllowed = False   
            Else   
                Throw ex  
            End If  
        End Try  
    End If  
End Sub  
```  
  
```csharp  
private void ButtonOpen_Click(object sender, System.EventArgs e)   
{  
    String editingFileName = "";  
    Boolean saveAllowed = true;  
  
    // Displays the OpenFileDialog.  
    if (openFileDialog1.ShowDialog() == DialogResult.OK)   
    {  
        // Opens the file stream for the file selected by the user.  
        using (System.IO.Stream userStream = openFileDialog1.OpenFile())   
        {  
            this.RtfBoxMain.LoadFile(userStream,  
                RichTextBoxStreamType.PlainText);  
            userStream.Close();  
        }  
  
        // Tries to get the file name selected by the user.  
        // Failure means that the application does not have  
        // unrestricted permission to the file.  
        try   
        {  
            editingFileName = openFileDialog1.FileName;  
        }   
        catch (Exception ex)   
        {  
            if (ex is System.Security.SecurityException)   
            {  
                // The application does not have unrestricted permission   
                // to the file so the save feature will be disabled.  
                saveAllowed = false;   
            }   
            else   
            {  
                throw ex;  
            }  
        }  
    }  
}  
```  
  
> [!NOTE]
>  В Visual C# убедитесь, что код для включения обработчика событий добавлен. С помощью кода из предыдущего примера, ниже показано, как включить обработчик событий.`this.ButtonOpen.Click += newSystem.Windows.Forms.EventHandler(this.ButtonOpen_Click);`  
  
### <a name="other-files"></a>Другие файлы  
 Иногда необходимо считывать или записывать файлы, которые не указываются пользователем, например если требуется сохранить параметры приложения. В зонах локальной интрасети и Интернета приложение не имеет разрешения сохранять данные в локальном файле. Тем не менее приложение может сохранять данные в изолированном хранилище. Изолированное хранилище — это абстрактная секция данных (а не конкретное хранилище), содержащая один или несколько изолированных файлов хранения, называемых хранилищами, которые содержат сведения о действительных папках размещения данных. Разрешения на доступ к файлам, такие как <xref:System.Security.Permissions.FileIOPermission>, не обязательны; вместо этого класс <xref:System.Security.Permissions.IsolatedStoragePermission> управляет разрешениями для изолированного хранилища. По умолчанию приложения, запущенные в зонах локальной интрасети и Интернета, могут хранить данные с помощью изолированного хранилища. Однако такие параметры, как дисковая квота, могут меняться. Дополнительные сведения об изолированном хранилище см. в разделе [изолированное хранилище](../../standard/io/isolated-storage.md).  
  
 В примере ниже для записи данных в файл, расположенный в хранилище, используется изолированное хранилище. Для этого примера требуется разрешение <xref:System.Security.Permissions.IsolatedStorageFilePermission> и значение перечисления <xref:System.Security.Permissions.IsolatedStorageContainment.DomainIsolationByUser>. В примере демонстрируется чтение и запись определенных значений свойств элемента управления <xref:System.Windows.Forms.Button> в файл в изолированном хранилище. Функция `Read` может быть вызвана после запуска приложения, а функция `Write` — до окончания работы приложения. В этом примере требуется `Read` и `Write` функций существует как члены <xref:System.Windows.Forms.Form> , содержащий <xref:System.Windows.Forms.Button> управления с именем `MainButton`.  
  
```vb  
' Reads the button options from the isolated storage. Uses Default values   
' for the button if the options file does not exist.  
Public Sub Read()   
    Dim isoStore As System.IO.IsolatedStorage.IsolatedStorageFile = _  
        System.IO.IsolatedStorage.IsolatedStorageFile. _   
        GetUserStoreForDomain()  
  
    Dim filename As String = "options.txt"  
    Try  
        ' Checks to see if the options.txt file exists.  
        If (isoStore.GetFileNames(filename).GetLength(0) <> 0) Then  
  
            ' Opens the file because it exists.  
            Dim isos As New System.IO.IsolatedStorage.IsolatedStorageFileStream _   
                 (filename, IO.FileMode.Open,isoStore)  
            Dim reader as System.IO.StreamReader  
            Try   
                reader = new System.IO.StreamReader(isos)  
  
                ' Reads the values stored.  
                Dim converter As System.ComponentModel.TypeConverter  
                converter = System.ComponentModel.TypeDescriptor.GetConverter _   
                    (GetType(Color))  
  
                Me.MainButton.BackColor = _   
                        CType(converter.ConvertFromString _   
                         (reader.ReadLine()), Color)  
                me.MainButton.ForeColor = _  
                        CType(converter.ConvertFromString _   
                         (reader.ReadLine()), Color)  
  
                converter = System.ComponentModel.TypeDescriptor.GetConverter _   
                    (GetType(Font))  
                me.MainButton.Font = _  
                        CType(converter.ConvertFromString _   
                         (reader.ReadLine()), Font)  
  
            Catch ex As Exception  
                Debug.WriteLine("Cannot read options " + _  
                    ex.ToString())  
            Finally  
                reader.Close()  
            End Try  
        End If  
  
    Catch ex As Exception  
        Debug.WriteLine("Cannot read options " + ex.ToString())  
    End Try  
End Sub  
  
' Writes the button options to the isolated storage.  
Public Sub Write()   
    Dim isoStore As System.IO.IsolatedStorage.IsolatedStorageFile = _  
        System.IO.IsolatedStorage.IsolatedStorageFile. _   
        GetUserStoreForDomain()  
  
    Dim filename As String = "options.txt"  
    Try   
        ' Checks if the file exists, and if it does, tries to delete it.  
        If (isoStore.GetFileNames(filename).GetLength(0) <> 0) Then  
            isoStore.DeleteFile(filename)  
        End If  
    Catch ex As Exception  
        Debug.WriteLine("Cannot delete file " + ex.ToString())  
    End Try  
  
    ' Creates the options.txt file and writes the button options to it.  
    Dim writer as System.IO.StreamWriter  
    Try   
        Dim isos As New System.IO.IsolatedStorage.IsolatedStorageFileStream _   
             (filename, IO.FileMode.CreateNew, isoStore)  
  
        writer = New System.IO.StreamWriter(isos)  
        Dim converter As System.ComponentModel.TypeConverter  
  
        converter = System.ComponentModel.TypeDescriptor.GetConverter _   
           (GetType(Color))  
        writer.WriteLine(converter.ConvertToString( _  
            Me.MainButton.BackColor))  
        writer.WriteLine(converter.ConvertToString( _  
            Me.MainButton.ForeColor))  
  
        converter = System.ComponentModel TypeDescriptor.GetConverter _   
           (GetType(Font))  
        writer.WriteLine(converter.ConvertToString( _  
            Me.MainButton.Font))  
  
    Catch ex as Exception  
        Debug.WriteLine("Cannot write options " + ex.ToString())  
  
    Finally  
        writer.Close()  
    End Try  
End Sub  
```  
  
```csharp  
// Reads the button options from the isolated storage. Uses default values   
// for the button if the options file does not exist.  
public void Read()   
{  
    System.IO.IsolatedStorage.IsolatedStorageFile isoStore =   
        System.IO.IsolatedStorage.IsolatedStorageFile.  
        GetUserStoreForDomain();  
  
    string filename = "options.txt";  
    try  
    {  
        // Checks to see if the options.txt file exists.  
        if (isoStore.GetFileNames(filename).GetLength(0) != 0)   
        {  
            // Opens the file because it exists.  
            System.IO.IsolatedStorage.IsolatedStorageFileStream isos =   
                new System.IO.IsolatedStorage.IsolatedStorageFileStream  
                    (filename, System.IO.FileMode.Open,isoStore);  
            System.IO.StreamReader reader = null;  
            try   
            {  
                reader = new System.IO.StreamReader(isos);  
  
                // Reads the values stored.  
                TypeConverter converter ;  
                converter = TypeDescriptor.GetConverter(typeof(Color));  
  
                this.MainButton.BackColor =   
                 (Color)(converter.ConvertFromString(reader.ReadLine()));  
                this.MainButton.ForeColor =   
                 (Color)(converter.ConvertFromString(reader.ReadLine()));  
  
                converter = TypeDescriptor.GetConverter(typeof(Font));  
                this.MainButton.Font =   
                  (Font)(converter.ConvertFromString(reader.ReadLine()));  
            }  
            catch (Exception ex)  
            {   
                System.Diagnostics.Debug.WriteLine  
                     ("Cannot read options " + ex.ToString());  
            }  
            finally  
            {  
                reader.Close();  
            }  
        }  
    }   
    catch (Exception ex)   
    {  
        System.Diagnostics.Debug.WriteLine  
            ("Cannot read options " + ex.ToString());  
    }  
}  
  
// Writes the button options to the isolated storage.  
public void Write()   
{  
    System.IO.IsolatedStorage.IsolatedStorageFile isoStore =   
        System.IO.IsolatedStorage.IsolatedStorageFile.  
        GetUserStoreForDomain();  
  
    string filename = "options.txt";  
    try   
    {  
        // Checks if the file exists and, if it does, tries to delete it.  
        if (isoStore.GetFileNames(filename).GetLength(0) != 0)   
        {  
            isoStore.DeleteFile(filename);  
        }  
    }  
    catch (Exception ex)   
    {  
        System.Diagnostics.Debug.WriteLine  
            ("Cannot delete file " + ex.ToString());  
    }  
  
    // Creates the options file and writes the button options to it.  
    System.IO.StreamWriter writer = null;  
    try   
    {  
        System.IO.IsolatedStorage.IsolatedStorageFileStream isos = new   
            System.IO.IsolatedStorage.IsolatedStorageFileStream(filename,   
            System.IO.FileMode.CreateNew,isoStore);  
  
        writer = new System.IO.StreamWriter(isos);  
        TypeConverter converter ;  
  
        converter = TypeDescriptor.GetConverter(typeof(Color));  
        writer.WriteLine(converter.ConvertToString(  
            this.MainButton.BackColor));  
        writer.WriteLine(converter.ConvertToString(  
            this.MainButton.ForeColor));  
  
        converter = TypeDescriptor.GetConverter(typeof(Font));  
        writer.WriteLine(converter.ConvertToString(  
            this.MainButton.Font));  
  
    }  
    catch (Exception ex)  
    {   
        System.Diagnostics.Debug.WriteLine  
           ("Cannot write options " + ex.ToString());  
    }  
    finally  
    {  
        writer.Close();  
    }  
}  
```  
  
## <a name="database-access"></a>Доступ к базе данных  
 Разрешения, необходимые для доступа к базе данных, различаются в зависимости от поставщика базы данных. Однако только приложения с соответствующими разрешениями могут получить доступ к базе данных через подключение данных. Дополнительные сведения о разрешениях, необходимых для доступа к базе данных см. в разделе [управления доступом для кода и ADO.NET](../data/adonet/code-access-security.md).  
  
 Если невозможно получить доступ к базе данных напрямую, так как требуется, чтобы приложение работало в среде с частичным доверием, можно использовать веб-службу как альтернативное средство доступа к данным. Веб-служба — это программа, доступ к которой можно получить программными средствами по сети. С помощью веб-служб приложения могут совместно использовать данные из различных зон групп кода. По умолчанию приложения в зонах локальной интрасети и Интернета получают право на доступ к исходным сайтам, что позволяет им вызывать веб-службы, размещенные на том же сервере. Дополнительные сведения см. в разделе [веб-служб в AJAX для ASP.NET](https://docs.microsoft.com/previous-versions/aspnet/bb398785(v=vs.100)) или [Windows Communication Foundation](../wcf/index.md).  
  
## <a name="registry-access"></a>Доступ к реестру  
 Класс <xref:System.Security.Permissions.RegistryPermission> управляет доступом к реестру операционной системы. По умолчанию доступ к реестру могут получить только приложения, которые работают локально.  <xref:System.Security.Permissions.RegistryPermission> предоставляет приложению право на доступ к реестру; попробуйте он не гарантирует, что доступ будет успешным, поскольку операционная система по-прежнему обеспечивает безопасность реестра.  
  
 Так как в среде с частичным доверием доступ к реестру получить невозможно, могут потребоваться другие способы хранения данных. Для хранения параметров приложения используйте вместо реестра изолированное хранилище. Изолированное сохранение можно использовать также для хранения файлов, относящихся к приложению. Можно хранить общие сведения приложения о сервере или исходном сайте, так как по умолчанию приложение имеет право на доступ к исходному сайту.  
  
## <a name="see-also"></a>См. также

- [Более безопасная печать в Windows Forms](more-secure-printing-in-windows-forms.md)
- [Дополнительные вопросы безопасности в формах Windows Forms](additional-security-considerations-in-windows-forms.md)
- [Общие сведения о безопасности в Windows Forms](security-in-windows-forms-overview.md)
- [Безопасность Windows Forms](windows-forms-security.md)
- [Mage.exe (средство создания и редактирования манифеста)](../tools/mage-exe-manifest-generation-and-editing-tool.md)
- [MageUI.exe (средство создания и редактирования манифестов, графический клиент)](../tools/mageui-exe-manifest-generation-and-editing-tool-graphical-client.md)
