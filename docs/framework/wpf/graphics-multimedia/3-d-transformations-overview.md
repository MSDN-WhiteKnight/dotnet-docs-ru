---
title: Общие сведения о трехмерных преобразованиях
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- 3-D transformations
- transformations [WPF], 3-D
ms.assetid: e45e555d-ac1e-4b36-aced-e433afe7f27f
ms.openlocfilehash: bbb3c413148bd2e2ab8de8a1a725f2d9a8acf2f6
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59190636"
---
# <a name="3-d-transformations-overview"></a>Общие сведения о трехмерных преобразованиях
В этом разделе описывается применение преобразований к трехмерным моделям в графической системе Windows Presentation Foundation (WPF). Преобразования позволяют разработчикам перемещать модели, изменять их размер и направление, при этом не затрагивая их базовые определяющие значения.  

## <a name="3-d-coordinate-space"></a>Координаты трехмерного пространства  
 Трехмерное графическое содержимое в Windows Presentation Foundation (WPF) инкапсулировано в элементе, <xref:System.Windows.Controls.Viewport3D>, который может участвовать в структуре двумерного элемента. Графическая система рассматривает Viewport3D как двумерный визуальный элемент, подобный многим другим в Windows Presentation Foundation (WPF). Viewport3D функционирует как окно — окно просмотра — трехмерной сцены. Говоря точнее, это поверхность, на которую проецируется трехмерная сцена.  Хотя Viewport3D можно использовать с другими двумерными объектами рисования в том же графе сцены, двумерные объекты нельзя преобразовать в трехмерные внутри Viewport3D. В следующем обсуждении описанное координатное пространство расположено в элементе Viewport3D.  
  
 Система координат Windows Presentation Foundation (WPF) для двумерной графики начинается в левом верхнем углу области отрисовки (обычно областью отрисовки является экран). В двумерной системе положительные значения оси X откладываются вправо, а оси Y — сверху вниз. В трехмерной системе координат начало располагается в центре отрисовываемой области, положительные значения оси X откладываются вправо, оси Y — снизу вверх, а оси Z — из центра к наблюдателю.  
  
 ![Системы координат](./media/coordsystem-1.png "CoordSystem-1")  
Сравнение системы координат  
  
 Пространство, определяемое этими осями, является стационарной системой отсчета координат для трехмерных объектов в приложении Windows Presentation Foundation (WPF). При построении моделей в этом пространстве и создании источников света и камер для их отображения необходимо отличать стационарную систему отсчета координат ("мировую систему координат") от локальной системы отсчета, которая создается для каждой модели при применении к ней преобразований. Помните, что в зависимости от освещения и настроек камеры объекты в мировой системе координат могут выглядеть различным образом или быть полностью невидимыми. При этом положение камеры не изменяет расположения объектов в мировой системе координат.  
  
## <a name="transforming-models"></a>Преобразование моделей  
 При создании моделей в сцене им задается определенное местоположение. Для поворота моделей, изменения их размера или перемещения внутри сцены не следует изменять вершины, определяющие сами модели. Вместо этого следует применять к моделям преобразования, как и в двумерных системах.  
  
 Каждый объект модели имеет <xref:System.Windows.Media.Media3D.Model3D.Transform%2A> свойства с помощью которого можно перемещать, повторно разобраться с функциональностью или изменении размера модели. При применении преобразования все точки модели фактически смещаются с помощью определенного вектора или значения, заданного преобразованием. Другими словами, выполняется преобразование координатного пространства, в котором определена модель ("пространство модели"), при этом значения, составляющие геометрию модели в системе координат всей сцены ("мировое пространство"), не изменяются.  
  
## <a name="translation-transformations"></a>Преобразования перевода  
 Трехмерные преобразования наследуют от абстрактного базового класса <xref:System.Windows.Media.Media3D.Transform3D>; к ним относятся классы аффинного преобразования <xref:System.Windows.Media.Media3D.TranslateTransform3D>, <xref:System.Windows.Media.Media3D.ScaleTransform3D>, и <xref:System.Windows.Media.Media3D.RotateTransform3D>. Windows Presentation Foundation (WPF) Трехмерная система также предоставляет <xref:System.Windows.Media.Media3D.MatrixTransform3D> класс, который позволяет указать те же преобразования в более коротких матричных операциях.  
  
 <xref:System.Windows.Media.Media3D.TranslateTransform3D> перемещает все точки в Model3D в направлении выбранного вектора смещения указывается с помощью <xref:System.Windows.Media.Media3D.TranslateTransform3D.OffsetX%2A>, <xref:System.Windows.Media.Media3D.TranslateTransform3D.OffsetY%2A>, и <xref:System.Windows.Media.Media3D.TranslateTransform3D.OffsetZ%2A> свойства. Например, если задать вершине куба с координатами (2, 2, 2) вектор смещения (0, 1,6, 1), то вершина (2, 2, 2) будет перемещена в точку (2, 3,6, 3). В пространстве модели вершина куба останется в точке (2, 2, 2), но, поскольку связь пространства модели с мировым пространством изменилась, координата пространства модели (2, 2, 2) будет находиться в точке (2, 3,6, 3) мирового пространства.  
  
 ![Фигура перевода](./media/transforms-translate.png "перевод преобразований")  
Перевод со смещением  
  
 В следующем примере кода показано, как применить перевод.  
  
 [!code-xaml[animation3dgallery_snip#Translation3DAnimationExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/Translation3DAnimationExample.xaml#translation3danimationexamplewholepage)]  
  
## <a name="scale-transformations"></a>Преобразования масштаба  
 <xref:System.Windows.Media.Media3D.ScaleTransform3D> изменяет масштаб модели с помощью указанного вектора масштаба относительно центральной точки. Укажите единый масштаб, который масштабирует модель по осям X, Y и Z для пропорционального изменения ее размера. Например, задание преобразования <xref:System.Windows.Media.ScaleTransform.ScaleX%2A>, <xref:System.Windows.Media.ScaleTransform.ScaleY%2A>, и <xref:System.Windows.Media.Media3D.ScaleTransform3D.ScaleZ%2A> свойства 0,5 уменьшению размера модели; значение 2 те же свойства удваивает его масштаб в всем трем осям.  
  
 ![Универсальный ScaleTransform3D](./media/threecubes-uniformscale-1.png "threecubes_uniformscale_1")  
Пример ScaleVector  
  
 Указание преобразования неоднородной шкалы (т. е. шкалы, значения X, Y и Z которой отличаются) может привести к растягиванию или сжатию модели в одном или двух измерениях без изменения по остальным. Например, установка <xref:System.Windows.Media.ScaleTransform.ScaleX%2A> 1, <xref:System.Windows.Media.ScaleTransform.ScaleY%2A> 2, и <xref:System.Windows.Media.Media3D.ScaleTransform3D.ScaleZ%2A> 1 приведет к модели в дважды в высоту, но остаются неизменными по осям X и Z.  
  
 По умолчанию ScaleTransform3D растягивает или сжимает вершины по отношению к началу координат (0, 0, 0). Но если преобразуемая модель строится не от начала координат, то при ее масштабировании от начала координат она будет находиться "не на своем месте" В то же время, если вершины модели умножаются на вектор масштабирования, операция масштабирования приведет и к преобразованию модели, и к ее масштабированию.  
  
 ![Три куба, масштабированные с указанной центральной точкой](./media/threecubes-scaledwithcenter-1.png "threecubes_scaledwithcenter_1")  
Пример центра масштабирования  
  
 Для масштабирования модели «на месте», укажите центр модели, установив свойства ScaleTransform3D <xref:System.Windows.Media.ScaleTransform.CenterX%2A>, <xref:System.Windows.Media.ScaleTransform.CenterY%2A>, и <xref:System.Windows.Media.Media3D.ScaleTransform3D.CenterZ%2A> свойства. Это гарантирует, что графической системе отмасштабировать пространство модели и затем преобразовать его к центру на указанном <xref:System.Windows.Media.Media3D.Point3D>. В обратном случае, если для построенной относительно начала координат модели указана другая центральная точка, модель будет преобразована из начала координат.  
  
## <a name="rotation-transformations"></a>Преобразования поворота  
 Трехмерную модель можно поворачивать несколькими способами. При обычном преобразовании поворота указываются ось и угол поворота вокруг этой оси. <xref:System.Windows.Media.Media3D.RotateTransform3D> Класс позволяет определить <xref:System.Windows.Media.Media3D.Rotation3D> с его <xref:System.Windows.Media.Media3D.RotateTransform3D.Rotation%2A> свойство. Затем укажите <xref:System.Windows.Media.Media3D.AxisAngleRotation3D.Axis%2A> и <xref:System.Windows.Media.Media3D.AxisAngleRotation3D.Angle%2A> свойства в Rotation3D, в данном случае <xref:System.Windows.Media.Media3D.AxisAngleRotation3D>, для определения преобразования. В следующих примерах модель поворачивается на 60 градусов вокруг оси Y.  
  
 [!code-xaml[animation3dgallery_snip#Rotate3DUsingAxisAngleRotation3DExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/Rotat3DUsingAxisAngleRotation3DExample.xaml#rotate3dusingaxisanglerotation3dexamplewholepage)]  
  
 Примечание.Windows Presentation Foundation (WPF) Является правовинтовой системой, это означает, что положительного значения угла поворота приведет к повороту против часовой стрелки относительно оси.  
  
 Осе угловой поворот предполагает Поворот относительно начала координат, если значение не указано для <xref:System.Windows.Media.Media3D.RotateTransform3D.CenterX%2A>, <xref:System.Windows.Media.Media3D.RotateTransform3D.CenterY%2A>, и <xref:System.Windows.Media.Media3D.RotateTransform3D.CenterZ%2A> свойства в RotateTransform3D. Как и при масштабировании, следует помнить, что при повороте преобразуется все координатное пространство модели целиком. Если модель была создана не от начала координат или была преобразована ранее, то поворот может быть произведен относительно начала координат, а не относительно местоположения модели.  
  
 ![Поворот с новой центральной точкой](./media/threecubes-rotationwithcenter-1.png "threecubes_rotationwithcenter_1")  
Поворот с указанием новой центральной точки  
  
 Чтобы повернуть модель "на месте", следует указать фактический центр модели в качестве центра поворота. Геометрия обычно моделируется от начала координат, поэтому для получения ожидаемого результата от набора преобразований необходимо вначале изменить размер модели (т. е. отмасштабировать), задать ее направление (повернуть), а затем перенести ее в нужное место (преобразовать).  
  
 ![Поворот на 60 градусов в x&#45; и y&#45;осей](./media/twocubes-rotation2axes-1.png "twocubes_rotation2axes_1")  
Пример поворота  
  
 Осе-угловой поворот подходит для статических преобразований и некоторых анимаций. Тем не менее рассмотрим поворот модели куба на 60 градусов вокруг оси X, а затем на 45 градусов вокруг оси Z. Это преобразование можно описать как два отдельных аффинных преобразования или как матрицу. Тем не менее плавно анимировать поворот, определенный таким образом, может быть достаточно трудно. Несмотря на то что начальные и конечные позиции вычисляемой модели совпадают, промежуточные положения модели не определены при вычислении. Кватернионы представляют собой альтернативный способ вычисления интерполяции между начальной и конечной точками поворота.  
  
 Кватернион представляет ось в трехмерном пространстве и поворот вокруг этой оси. Например, кватернион может быть представлен осью (1, 1, 2) и поворотом на 50 градусов. Возможности определения поворотов с помощью кватернионов зависят от двух операций, которые могут быть выполнены над ними: композиции и интерполяции. Композиция из двух кватернионов, применяемая к геометрическому объекту, означает "поворот геометрического объекта вокруг axis2 на угол rotation2, затем — вокруг axis1 на угол rotation1". С помощью композиции можно объединить два поворота геометрического объекта для получения одного квантериона, представляющего собой результат. Поскольку интерполяция кватернионов позволяет вычислить плавный и наиболее подходящий путь от одной оси и ориентацию относительно другой, разработчик может выполнить интерполяцию из исходного кватерниона в результирующий для достижения плавного перехода от одного к другому. Это позволит анимировать преобразование. Для моделей, которые вы хотите анимировать, можно указать целевой <xref:System.Windows.Media.Media3D.Quaternion> для поворота с помощью <xref:System.Windows.Media.Media3D.QuaternionRotation3D> для <xref:System.Windows.Media.Media3D.RotateTransform3D.Rotation%2A> свойство.  
  
## <a name="using-transformation-collections"></a>Использование коллекции преобразований  
 При построении сцены обычно применяется несколько преобразований модели. Добавьте преобразования <xref:System.Windows.Media.Media3D.Transform3DGroup.Children%2A> коллекцию <xref:System.Windows.Media.Media3D.Transform3DGroup> класса, чтобы сгруппировать их для удобства применения к различным моделям сцены. Часто удобно повторно использовать преобразование в нескольких различных группах (подобно повторному использованию модели путем применения разных наборов преобразований к экземплярам). Обратите внимание, что порядок добавления преобразований в коллекцию имеет значение: преобразования в коллекции применяются начиная с первого.  
  
## <a name="animating-transformations"></a>Анимация преобразований  
 Трехмерная реализация Windows Presentation Foundation (WPF) участвует в той же системе анимации и времени, что и двумерная графика. Другими словами, для анимации трехмерной сцены необходимо анимировать свойства ее моделей. Можно непосредственно анимировать свойства примитивов, но обычно проще анимировать преобразования, изменяющие позицию или внешний вид моделей. Поскольку преобразования можно применить и к <xref:System.Windows.Media.Media3D.Model3DGroup> объекты, а также отдельным моделям, это возможно применение одного набора анимаций к дочернему элементу Model3Dgroup, а другого набора — к группе объектов.  Дополнительные сведения о системе времени и анимации Windows Presentation Foundation (WPF) см. в разделах [Общие сведения об эффектах анимации](animation-overview.md) и [Общие сведения о Storyboard](storyboards-overview.md).  
  
 Для анимации объекта в приложении Windows Presentation Foundation (WPF) создайте временную шкалу, определите анимацию (которая изменяет значение некоторого свойства во времени) и укажите свойство, к которому применяется анимация. Это свойство должно быть свойством элемента FrameworkElement. Поскольку все объекты в трехмерной сцене являются дочерними для Viewport3D, то свойства, требуемые для анимации сцены, являются свойствами свойств Viewport3D. Важно правильно указать путь к свойству для анимации, так как синтаксис может быть подробным.  
  
 Предположим, требуется повернуть объект на месте, а также применить качательное движение, чтобы лучше показать объект. Можно применить к модели класс RotateTransform3D и анимировать ее ось вращения от одного вектора к другому. В следующем примере кода демонстрируется применение <xref:System.Windows.Media.Animation.Vector3DAnimation> к свойству Axis преобразования элемента Rotation3D, при условии, что RotateTransform3D будет одним из нескольких преобразований, применяемых к модели с <xref:System.Windows.Media.TransformGroup>.  
  
 [!code-csharp[3doverview#3DOverview3DN1](~/samples/snippets/csharp/VS_Snippets_Wpf/3DOverview/CSharp/Window1.xaml.cs#3doverview3dn1)]
   
  
 [!code-csharp[3doverview#3DOverview3DN3](~/samples/snippets/csharp/VS_Snippets_Wpf/3DOverview/CSharp/Window1.xaml.cs#3doverview3dn3)]
   
  
 Используйте аналогичный синтаксис для других свойств преобразования, чтобы переместить или отмасштабировать объект.  Например, можно применить <xref:System.Windows.Media.Animation.Point3DAnimation> к свойству ScaleCenter при преобразовании масштаба модели к плавной деформации ее формы.  
  
 Несмотря на то, что предыдущих примерах происходило преобразование свойств <xref:System.Windows.Media.Media3D.GeometryModel3D>, можно также преобразовывать свойства других моделей сцены.  Например, применяя преобразования анимации к объектам Light, можно создать перемещение световых и теневых эффектов, которые могут значительным образом изменить внешний вид модели.  
  
 Поскольку камеры также являются моделями, их свойства также могут быть преобразованы.  Хотя внешний вид сцены можно изменить путем преобразования местоположения камеры или расстояний на плоскости (т. е. преобразованием всей проекции сцены целиком), обратите внимание, что многие эффекты, созданные таким способом, не создадут такого же впечатления, как преобразования, примененные к расположению или положению моделей в сцене.  
  
## <a name="see-also"></a>См. также

- [Обзор трехмерной графики](3-d-graphics-overview.md)
- [Общие сведения о классах Transform](transforms-overview.md)
- [Пример двумерных преобразований](https://go.microsoft.com/fwlink/?LinkID=158252)
