---
description: 'Узнайте подробнее о: XML-документы и данные'
title: XML-документы и данные
ms.date: 03/30/2017
ms.assetid: e695047f-3c0f-4045-8708-5baea91cc380
ms.openlocfilehash: c2f64c218f2f6051f27087a98616b17e57583f75
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99713667"
---
# <a name="xml-documents-and-data"></a>XML-документы и данные

Платформа .NET Framework имеет всеобъемлющий и интегрированный набор классов, с помощью которых можно легко создавать приложения, использующие XML. Классы из следующих пространств имен поддерживают синтаксический анализ и запись XML-кода, изменение XML-данных в памяти, проверку данных и преобразование XSLT.

- <xref:System.Xml>

- <xref:System.Xml.XPath>

- <xref:System.Xml.Xsl>

- <xref:System.Xml.Schema>

- <xref:System.Xml.Linq>

Чтобы получить полный список, выполните поиск System.Xml в [браузере API .NET](../../../../api/index.md?term=system.xml).

Классы из этих пространств имен поддерживают рекомендации W3C. Пример:

- Класс <xref:System.Xml.XmlDocument?displayProperty=nameWithType> реализует рекомендации модели W3C [DOM базового уровня 1](https://www.w3.org/TR/REC-DOM-Level-1/) и [DOM базового уровня 2](https://www.w3.org/TR/DOM-Level-2-Core/).

- Классы <xref:System.Xml.XmlReader?displayProperty=nameWithType> и <xref:System.Xml.XmlWriter?displayProperty=nameWithType> поддерживают рекомендации [W3C XML 1.0](https://www.w3.org/TR/2006/REC-xml-20060816/) и [Пространства имен в XML](https://www.w3.org/TR/REC-xml-names/).

- Схемы в классе <xref:System.Xml.Schema.XmlSchemaSet?displayProperty=nameWithType> поддерживают рекомендации в разделах [Схема XML W3C, часть 1. Структуры](https://www.w3.org/TR/xmlschema-1/) и [Схема XML, часть 2. Типы данных](https://www.w3.org/TR/xmlschema-2/).

- Классы в пространстве имен <xref:System.Xml.Xsl?displayProperty=nameWithType> поддерживают преобразования XSLT, соответствующие рекомендациям [W3C XSLT 1.0](https://www.w3.org/TR/xslt).

Классы XML в платформе .NET Framework предоставляют следующие преимущества.

- **Производительность** [LINQ to XML (C#)](../../linq/linq-xml-overview.md) и [LINQ to XML (Visual Basic)](../../linq/linq-xml-overview.md) упрощает программирование с использованием XML и обеспечивает работу с запросами, похожую на работу в SQL.

- **Расширяемость** XML-классы в .NET Framework являются расширяемыми, что было достигнуто за счет использования абстрактных базовых классов и виртуальных методов. Например, можно создать класс, производный от класса <xref:System.Xml.XmlUrlResolver>, который будет сохранять поток кэширования на локальном диске.

- **Модульная архитектура** Платформа .NET Framework обеспечивает архитектуру, в которой компоненты могут использовать друг друга, а данные можно передавать в потоках между компонентами. Например, хранилище данных, такое как объект <xref:System.Xml.XPath.XPathDocument> или <xref:System.Xml.XmlDocument>, можно преобразовать с помощью класса <xref:System.Xml.Xsl.XslCompiledTransform>, а выходные данные затем могут быть переданы в виде потока в другое хранилище или возвращены в виде потока из веб-службы XML.

- **Производительность.** С целью повышения быстродействия приложений некоторые XML-классы в .NET Framework поддерживают модель на основе потоковой передачи со следующими характеристиками.

  - Минимальное кэширование для анализа по запросу в однопроходном режиме (<xref:System.Xml.XmlReader>).

  - Проверка в однопроходном режиме (<xref:System.Xml.XmlReader>).

  - Навигация, аналогичная курсорам, которая сводит создание узлов к минимуму (до одного виртуального узла) и обеспечивает произвольный доступ к документу (<xref:System.Xml.XPath.XPathNavigator>).

  В случае если требуется обработка XSLT, для повышения производительности можно использовать класс <xref:System.Xml.XPath.XPathDocument>, который является оптимизированным хранилищем «только для чтения» для запросов XPath, обеспечивающих эффективное взаимодействие с классом <xref:System.Xml.Xsl.XslCompiledTransform>.

- **Интеграция с ADO.NET** Классы XML и [ADO.NET](../../../framework/data/adonet/index.md) тесно интегрированы для сведения воедино реляционных данных и XML. Класс <xref:System.Data.DataSet> представляет собой кэш «в памяти» для данных, полученных из базы данных. Класс <xref:System.Data.DataSet> позволяет считывать и записывать код XML с помощью классов <xref:System.Xml.XmlReader> и <xref:System.Xml.XmlWriter>, сохранять внутреннюю реляционную структуру в виде схем XML (XSD) и логически выводить структуру схем XML-документов.

## <a name="in-this-section"></a>В этом разделе

[Варианты обработки XML-данных](xml-processing-options.md) Обсуждаются параметры обработки XML-данных.

[Обработка XML-данных в памяти](processing-xml-data-in-memory.md) Содержит обсуждение трех моделей обработки XML-данных в памяти: [LINQ to XML (C#)](../../linq/linq-xml-overview.md) и [LINQ to XML (Visual Basic)](../../linq/linq-xml-overview.md), класс <xref:System.Xml.XmlDocument> (основанный на модели W3C DOM) и класс <xref:System.Xml.XPath.XPathDocument> (основанный на модели данных XPath).

[Преобразования XSLT](xslt-transformations.md)\
Описывается, как использовать обработчик XSLT.

[Модель объектов схемы XML (SOM)](xml-schema-object-model-som.md)\
Описываются классы, используемые для построения схем XML (XSD-файлов) и работы с ними, используя класс <xref:System.Xml.Schema.XmlSchema> для загрузки и изменения схемы.

[Интеграция XML с реляционными данными и ADO.NET](xml-integration-with-relational-data-and-adonet.md)\
Описывается, как платформа .NET Framework реализует синхронный доступ в режиме реального времени к данным в реляционном и иерархическом представлении с помощью объектов <xref:System.Data.DataSet> и <xref:System.Xml.XmlDataDocument>.

[Управление пространствами имен в XML-документе](managing-namespaces-in-an-xml-document.md)\
Описывает использование класса <xref:System.Xml.XmlNamespaceManager> для хранения и ведения информации о пространствах имен.

[Поддержка типов в классах System.Xml](type-support-in-the-system-xml-classes.md)\
Описывает сопоставление типов данных XML с типами CLR, преобразование типов данных XML и другие возможности по работе с типами, которые есть в классах <xref:System.Xml>.

## <a name="related-sections"></a>Связанные разделы

[ADO.NET](../../../framework/data/adonet/index.md)\
Приводятся сведения о доступе к данным с помощью ADO.NET.

[Безопасность](../../security/index.md)\
Приводятся общие сведения о системе безопасности в платформе .NET Framework.
