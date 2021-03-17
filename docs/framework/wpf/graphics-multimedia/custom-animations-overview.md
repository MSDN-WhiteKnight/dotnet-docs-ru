---
title: Общие сведения о пользовательской анимации
ms.date: 03/30/2017
helpviewer_keywords:
- custom classes [WPF], animation
- key frames [WPF], custom
- custom key frames [WPF]
- animation [WPF], custom classes
- custom animation classes [WPF]
ms.assetid: 9be69d50-3384-4938-886f-08ce00e4a7a6
ms.openlocfilehash: 268d218097233aee795154226cc6f7c3ce318f5c
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59313948"
---
# <a name="custom-animations-overview"></a>Общие сведения о пользовательской анимации
В этом разделе описывается, как и когда расширять систему анимации [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] путем создания пользовательских ключевых кадров и классов анимации или путем использования покадрового обратного вызова, чтобы пропустить ее.  
  
<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Чтобы понять материал этого раздела, необходимо ознакомиться с различными типами анимации, предоставляемыми [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Дополнительные сведения см. в разделах "Общие сведения об анимациях From/To/By", [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md) и [Общие сведения об анимация с использованием пути](path-animations-overview.md).  
  
 Поскольку классы анимации наследуют от <xref:System.Windows.Freezable> класса, вы должны быть знакомы с <xref:System.Windows.Freezable> объекты и способами наследования от класса <xref:System.Windows.Freezable>. Дополнительные сведения см. в разделе [Общие сведения об объектах класса Freezable](../advanced/freezable-objects-overview.md).  
  
<a name="extendingtheanimationsystem"></a>   
## <a name="extending-the-animation-system"></a>Расширение системы анимации  
 Существует несколько способов расширения системы анимации [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], которые зависят от уровня встроенного функционала, который будет использоваться.  В механизме анимации [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] имеются три основных точки расширяемости.  
  
-   Создание пользовательского объекта ключевого кадра путем наследования от одной из  *\<тип >* классы опорного кадра, например <xref:System.Windows.Media.Animation.DoubleKeyFrame>. Этот подход использует большую часть встроенных функциональных возможностей механизма анимации [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  
  
-   Создание собственного класса анимации путем наследования от <xref:System.Windows.Media.Animation.AnimationTimeline> или один из  *\<тип >* классы AnimationBase.  
  
-   Использование покадрового обратного вызова для создания анимаций на основе отдельных кадров. Такой подход предусматривает полный обход анимации и систему времени.  
  
 В следующей таблице описаны некоторые сценарии для расширения системы анимации.  
  
|Требуемое действие|Используемый подход|  
|-------------------------|-----------------------|  
|Настройка интерполяции между значениями типа, имеющего соответствующий класс *\<Type>* AnimationUsingKeyFrames|Создайте пользовательский ключевой кадр. Дополнительные сведения см. в разделе [Создание пользовательского ключевого кадра](#createacustomkeyframe).|  
|Настройка не только интерполяции между значениями типа, имеющего соответствующий класс *\<Type>* Animation.|Создайте пользовательский класс анимации, наследующий от класса *\<Type>* AnimationBase, соответствующего типу, который требуется анимировать. Дополнительные сведения см. в разделе [Создание пользовательского класса анимации](#createacustomanimationtype).|  
|Анимация типа, не имеющего соответствующей анимации [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]|Используйте <xref:System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames> или создать класс, наследуемый от <xref:System.Windows.Media.Animation.AnimationTimeline>. Дополнительные сведения см. в разделе [Создание пользовательского класса анимации](#createacustomanimationtype).|  
|Анимация нескольких объектов со значениями, которые вычисляются для каждого кадра и основаны на последнем наборе взаимодействий объектов|Используйте покадровый обратный вызов. Дополнительные сведения см. в разделе [Использование покадрового обратного вызова](#useperframecallback).|  
  
<a name="createacustomkeyframe"></a>   
## <a name="create-a-custom-key-frame"></a>Создание пользовательского ключевого кадра  
 Создание пользовательского ключевого кадра является простейшим способом расширения системы анимации. Этот подход следует использовать в случае, если требуется другой метод интерполяции для анимации по ключевым кадрам.  Как описано в разделе [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md), в анимации по ключевым кадрам используются объекты ключевых кадров для создания выходных значений. Каждый объект ключевого кадра выполняет три функции:  
  
-   Указывает целевое значение с помощью его <xref:System.Windows.Media.Animation.IKeyFrame.Value%2A> свойство.  
  
-   Указывает время, по которому это значение следует связаться с помощью его <xref:System.Windows.Media.Animation.IKeyFrame.KeyTime%2A> свойство.  
  
-   выполняет интерполяцию между значением предыдущего ключевого кадра и собственным значением с помощью метода InterpolateValueCore.  
  
 **Инструкции по реализации**  
  
 Выполните наследование от абстрактного класса *\<Type>* KeyFrame и реализуйте метод InterpolateValueCore. Метод InterpolateValueCore возвращает текущее значение ключевого кадра. Он принимает два параметра: значение предыдущего ключевого кадра и значение хода выполнения в диапазоне от 0 до 1. 0 означает ключевой кадр только что запущен, а значение 1 указывает, что ключевой кадр завершил работу и должен возвращать значение, заданное его <xref:System.Windows.Media.Animation.IKeyFrame.Value%2A> свойство.  
  
 Так как  *\<тип >* опорный кадр классы наследуют от <xref:System.Windows.Freezable> класса, необходимо также переопределить <xref:System.Windows.Freezable.CreateInstanceCore%2A> core для возврата нового экземпляра класса. Если класс не использует свойства зависимостей для хранения своих данных или требует дополнительной инициализации после создания, может потребоваться переопределить дополнительные методы. Дополнительные сведения см. в разделе [Общие сведения об объектах класса Freezable](../advanced/freezable-objects-overview.md).  
  
 После создания пользовательской анимации *\<Type>* KeyFrame ее можно использовать *\<Type>* AnimationUsingKeyFrames для данного типа.  
  
<a name="createacustomanimationtype"></a>   
## <a name="create-a-custom-animation-class"></a>Создание пользовательского класса анимации  
 Создание собственного типа анимации обеспечивает больший уровень контроля над способом анимации объекта. Существуют два рекомендованных способа создания собственного типа анимации: можно унаследовать <xref:System.Windows.Media.Animation.AnimationTimeline> класса или  *\<тип >* класс AnimationBase. Наследование от классов *\<Type>* Animation или *\<Type>* AnimationUsingKeyFrames не рекомендуется.  
  
### <a name="derive-from-typeanimationbase"></a>Наследование от класса \<Type>AnimationBase  
 Наследование от класса *\<Type>* AnimationBase является самым простым способом создания типа анимации. Этот подход следует использовать в случае, если требуется создать анимацию для типа, у которого уже есть соответствующий класс *\<Type>* AnimationBase.  
  
 **Инструкции по реализации**  
  
 Выполните наследование от класса *\<Type>* Animation и реализуйте метод GetCurrentValueCore. Метод GetCurrentValueCore возвращает текущее значение анимации. Он принимает три параметра: предлагаемое начальное значение, предлагаемое конечное значение и <xref:System.Windows.Media.Animation.AnimationClock>, используемый для определения хода выполнения анимации.  
  
 Так как  *\<тип >* AnimationBase наследуют от <xref:System.Windows.Freezable> класса, необходимо также переопределить <xref:System.Windows.Freezable.CreateInstanceCore%2A> core для возврата нового экземпляра класса. Если класс не использует свойства зависимостей для хранения своих данных или требует дополнительной инициализации после создания, может потребоваться переопределить дополнительные методы. Дополнительные сведения см. в разделе [Общие сведения об объектах класса Freezable](../advanced/freezable-objects-overview.md).  
  
 Дополнительные сведения см. в документации по методу GetCurrentValueCore для класса *\<Type>* AnimationBase по типу, который требуется анимировать. Например, см. раздел [Пример пользовательской анимации](https://go.microsoft.com/fwlink/?LinkID=159981).  
  
 **Альтернативные подходы**  
  
 Если просто требуется изменить способ интерполяции значений анимации, следует рассмотреть возможность наследования от одного из классов *\<Type>* KeyFrame. Создаваемый ключевой кадр может использоваться с соответствующим классом *\<Type>* AnimationUsingKeyFrames, предоставляемым [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  
  
### <a name="derive-from-animationtimeline"></a>Наследование от AnimationTimeline  
 Являются производными от <xref:System.Windows.Media.Animation.AnimationTimeline> класса, если требуется создать анимацию для типа, который уже не имеет соответствующего [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] анимацию или вы хотите создать анимацию, которая не является строго типизированным.  
  
 **Инструкции по реализации**  
  
 Являются производными от <xref:System.Windows.Media.Animation.AnimationTimeline> класса и переопределить следующие члены:  
  
-   <xref:System.Windows.Freezable.CreateInstanceCore%2A> — Если новый класс является конкретным, необходимо переопределить <xref:System.Windows.Freezable.CreateInstanceCore%2A> для возврата нового экземпляра класса.  
  
-   <xref:System.Windows.Media.Animation.AnimationTimeline.GetCurrentValue%2A> — Переопределите этот метод для возврата текущего значения анимации. Он принимает три параметра: начальное значение, конечное значение по умолчанию и <xref:System.Windows.Media.Animation.AnimationClock>. Используйте <xref:System.Windows.Media.Animation.AnimationClock> для получения текущего времени или ход выполнения анимации. Можно выбрать, какие значения будут использоваться: начальное значение по умолчанию или конечное значение по умолчанию.  
  
-   <xref:System.Windows.Media.Animation.AnimationTimeline.IsDestinationDefault%2A> — Нужно переопределить это свойство позволяет указать, использует ли анимация конечное значение по умолчанию, определяемое <xref:System.Windows.Media.Animation.AnimationTimeline.GetCurrentValue%2A> метод.  
  
-   <xref:System.Windows.Media.Animation.AnimationTimeline.TargetPropertyType%2A> — Нужно переопределить это свойство позволяет указать <xref:System.Type> выходных данных анимации.  
  
 Если класс не использует свойства зависимостей для хранения своих данных или требует дополнительной инициализации после создания, может потребоваться переопределить дополнительные методы. Дополнительные сведения см. в разделе [Общие сведения об объектах класса Freezable](../advanced/freezable-objects-overview.md).  
  
 Рекомендуемой концепцией (используемой анимациями [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]) является использование двух уровней наследования.  
  
1. Создание абстрактного  *\<тип >* AnimationBase класс, производный от <xref:System.Windows.Media.Animation.AnimationTimeline>. Этот класс должен переопределить <xref:System.Windows.Media.Animation.AnimationTimeline.TargetPropertyType%2A> метод. Он должен также представить новый абстрактный метод GetCurrentValueCore и переопределить <xref:System.Windows.Media.Animation.AnimationTimeline.GetCurrentValue%2A> таким образом, чтобы он проверял типы параметров значение по умолчанию назначения и начальное значение по умолчанию, затем метод GetCurrentValueCore.  
  
2. Создайте еще один класс, который наследует от нового  *\<тип >* класс AnimationBase и переопределяет <xref:System.Windows.Freezable.CreateInstanceCore%2A> метод, представленный, метод GetCurrentValueCore и <xref:System.Windows.Media.Animation.AnimationTimeline.IsDestinationDefault%2A> свойство.  
  
 **Альтернативные подходы**  
  
 Если вы хотите анимировать тип, не имеет соответствующей анимации From/To/By или анимации по ключевым кадрам, рассмотрите возможность использования <xref:System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames>. Так как для нее характерна слабая типизация, <xref:System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames> можно анимировать любой тип значения. Недостаток этого подхода заключается в том, <xref:System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames> поддерживает только дискретную интерполяцию.  
  
<a name="useperframecallback"></a>   
## <a name="use-per-frame-callback"></a>Использование покадрового обратного вызова  
 Этот подход следует использовать, если требуется полностью обойти систему анимации WPF [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Один из сценариев для такого подхода — анимация физики, при которой на каждом шаге анимации требуется пересчитывать новое направление или положение анимированных объектов на основе последнего набора взаимодействий объектов.  
  
 **Инструкции по реализации**  
  
 В отличие от других подходов, описанных в этом обзоре, здесь для использования покадрового обратного вызова не требуется создавать пользовательскую анимацию или класс ключевого кадра.  
  
 Вместо этого следует регистрировать для <xref:System.Windows.Media.CompositionTarget.Rendering> события объекта, который содержит объекты, которые требуется анимировать. Метод обработчика событий вызывается один раз для каждого кадра. Каждый раз, когда [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] выполняет маршалинг сохраненных данных отрисовки в визуальном дереве через дерево композиции, вызывается метод обработчика событий.  
  
 В обработчике событий выполняются все вычисления, необходимые для эффекта анимации, и задаются свойства объектов, которые требуется анимировать с этими значениями.  
  
 Чтобы получить время представления текущего кадра, <xref:System.EventArgs> связанный с данным событий может быть приведен как <xref:System.Windows.Media.RenderingEventArgs>, которые предоставляют <xref:System.Windows.Media.RenderingEventArgs.RenderingTime%2A> времени отрисовки свойство, которое можно использовать для получения текущего кадра.  
  
 Дополнительные сведения см. в разделе <xref:System.Windows.Media.CompositionTarget.Rendering> страницы.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.AnimationTimeline>
- <xref:System.Windows.Media.Animation.IKeyFrame>
- [Общие сведения о методах анимации свойств](property-animation-techniques-overview.md)
- [Общие сведения об объектах класса Freezable](../advanced/freezable-objects-overview.md)
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [Общие сведения об анимация с использованием пути](path-animations-overview.md)
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Общие сведения об анимации и системе управления временем](animation-and-timing-system-overview.md)
- [Пример пользовательской анимации](https://go.microsoft.com/fwlink/?LinkID=159981)
