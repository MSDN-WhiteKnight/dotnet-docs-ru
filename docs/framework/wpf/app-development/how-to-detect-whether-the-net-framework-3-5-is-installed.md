---
title: Практическое руководство. Проверка наличия установленной платформы .NET Framework 3.5
ms.date: 03/30/2017
helpviewer_keywords:
- verifying whether.NET Framework 3.5 is installed [WPF]
- detecting .NET Framework 3.5 installation [WPF]
- detecting whether.NET Framework 3.5 is installed [WPF]
- determining whether.NET Framework 3.5 is installed [WPF]
ms.assetid: 8556a9d2-1eb8-48ef-919c-5baf22a2a9a2
ms.openlocfilehash: af2428ece79803953b8c90431d905824dd18fec8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59074642"
---
# <a name="how-to-detect-whether-the-net-framework-35-is-installed"></a>Практическое руководство. Проверка наличия установленной платформы .NET Framework 3.5
Прежде чем развертывать приложения Windows Presentation Foundation (WPF) в системе, предназначенного [!INCLUDE[net_v35_short](../../../../includes/net-v35-short-md.md)], необходимо сначала убедиться, [!INCLUDE[net_v35_short](../../../../includes/net-v35-short-md.md)] присутствует среды выполнения. В этом разделе содержится скрипт, написанный на языке HTML/JavaScript, администраторы могут использовать для определения ли [!INCLUDE[net_v35_short](../../../../includes/net-v35-short-md.md)] присутствует в системе.  
  
> [!NOTE]
>  Более подробные сведения об установке, развертывании и обнаружении .NET Framework, см. в разделе [установка .NET Framework для разработчиков](../../install/guide-for-developers.md).  
  
## <a name="example"></a>Пример  
 Когда [!INCLUDE[net_v35_short](../../../../includes/net-v35-short-md.md)] является установки MSI-ФАЙЛ добавляет «CLR.NET» и номер версии строки UserAgent. Пример скрипта, внедренных в простую HTML-страницу. В скрипте выполняется поиск строки UserAgent, чтобы определить ли [!INCLUDE[net_v35_short](../../../../includes/net-v35-short-md.md)] устанавливается и отображается сообщение о состоянии по результатам поиска.  
  
> [!NOTE]
>  Этот сценарий предназначен для Internet Explorer. Другие браузеры могут не включать сведения о .NET CLR в строки UserAgent.  
  
```  
<HTML>  
  <HEAD>  
    <TITLE>Test for the .NET Framework 3.5</TITLE>  
    <META HTTP-EQUIV="Content-Type" CONTENT="text/html; charset=utf-8" />  
    <SCRIPT LANGUAGE="JavaScript">  
    <!--  
    var dotNETRuntimeVersion = "3.5.0.0";  
  
    function window::onload()  
    {  
      if (HasRuntimeVersion(dotNETRuntimeVersion))  
      {  
        result.innerText =   
          "This machine has the correct version of the .NET Framework 3.5."  
      }   
      else  
      {  
        result.innerText =   
          "This machine does not have the correct version of the .NET Framework 3.5." +  
          " The required version is v" + dotNETRuntimeVersion + ".";  
      }  
      result.innerText += "\n\nThis machine's userAgent string is: " +   
        navigator.userAgent + ".";  
    }  
  
    //  
    // Retrieve the version from the user agent string and   
    // compare with the specified version.  
    //  
    function HasRuntimeVersion(versionToCheck)  
    {  
      var userAgentString =   
        navigator.userAgent.match(/.NET CLR [0-9.]+/g);  
  
      if (userAgentString != null)  
      {  
        var i;  
  
        for (i = 0; i < userAgentString.length; ++i)  
        {  
          if (CompareVersions(GetVersion(versionToCheck),   
            GetVersion(userAgentString[i])) <= 0)  
            return true;  
        }  
      }  
  
      return false;  
    }  
  
    //  
    // Extract the numeric part of the version string.  
    //  
    function GetVersion(versionString)  
    {  
      var numericString =   
        versionString.match(/([0-9]+)\.([0-9]+)\.([0-9]+)/i);  
      return numericString.slice(1);  
    }  
  
    //  
    // Compare the 2 version strings by converting them to numeric format.  
    //  
    function CompareVersions(version1, version2)  
    {  
      for (i = 0; i < version1.length; ++i)  
      {  
        var number1 = new Number(version1[i]);  
        var number2 = new Number(version2[i]);  
  
        if (number1 < number2)  
          return -1;  
  
        if (number1 > number2)  
          return 1;  
      }  
  
      return 0;  
    }  
  
    -->  
    </SCRIPT>  
  </HEAD>  
  
  <BODY>  
    <div id="result" />  
  </BODY>  
</HTML>  
```  
  
 При успешном выполнении поиска для версии «CLR.NET», появится сообщение о состоянии следующего типа:  
  
 `This machine has the correct version of the .NET Framework 3.5.`  
  
 `This machine's userAgent string is: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; SLCC1; .NET CLR 2.0.50727; .NET CLR 1.1.4322; InfoPath.2; .NET CLR 3.0.590; .NET CLR 3.5.20726; MS-RTC LM 8).`  
  
 В противном случае отображается сообщение о состоянии следующего типа:  
  
 `This machine does not have the correct version of the .NET Framework 3.5. The required version is v3.5.0.0.`  
  
 `This machine's userAgent string is: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; SLCC1; .NET CLR 2.0.50727; .NET CLR 1.1.4322; InfoPath.2; .NET CLR 3.0.590; MS-RTC LM 8).`  
  
## <a name="see-also"></a>См. также

- [Проверка наличия установленной платформы .NET Framework 3.0](how-to-detect-whether-the-net-framework-3-0-is-installed.md)
