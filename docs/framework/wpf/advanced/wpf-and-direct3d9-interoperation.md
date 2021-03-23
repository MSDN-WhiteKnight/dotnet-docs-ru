---
title: Взаимодействие WPF и Direct3D9
ms.date: 03/30/2017
dev_langs:
- cpp
helpviewer_keywords:
- WPF [WPF], creating Direct3D9 content
- Direct3D9 [WPF interoperability], creating Direct3D9 content
ms.assetid: 1b14b823-69c4-4e8d-99e4-f6dade58f89a
ms.openlocfilehash: 38f5eb36e3e5c055c5a354a67e15cde8049a2967
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59307734"
---
# <a name="wpf-and-direct3d9-interoperation"></a>Взаимодействие WPF и Direct3D9
Можно включить содержимого Direct3D9 в приложении Windows Presentation Foundation (WPF). В этом разделе описывается создание содержимого Direct3D9 таким образом, чтобы эффективно взаимодействовать с WPF.  
  
> [!NOTE]
>  При использовании содержимого Direct3D9 в WPF, необходимо также подумать о производительности. Дополнительные сведения о том, как оптимизировать производительность, см. в разделе [рекомендации по ускорению взаимодействием Direct3D9 и WPF](performance-considerations-for-direct3d9-and-wpf-interoperability.md).  
  
## <a name="display-buffers"></a>Буферы отображения  
 <xref:System.Windows.Interop.D3DImage> Класс управляет двумя буферами отображения, которые называются *задний буфер* и *передний буфер*. Задний буфер — это область Direct3D9. Изменения на задний буфер копируются передний буфер при вызове <xref:System.Windows.Interop.D3DImage.Unlock%2A> метод.  
  
 Ниже показана связь между задний буфер и передний буфер.  
  
 ![Буферы отображения D3DImage](./media/d3dimage-buffers.png "D3DImage_buffers")  
  
## <a name="direct3d9-device-creation"></a>Создание устройства Direct3D9  
 Для отображения содержимого Direct3D9, необходимо создать устройство Direct3D9. Имеется два объекта Direct3D9, которые можно использовать для создания устройства, `IDirect3D9` и `IDirect3D9Ex`. Эти объекты можно использовать для создания `IDirect3DDevice9` и `IDirect3DDevice9Ex` устройств, соответственно.  
  
 Создание устройства путем вызова одного из следующих методов.  
  
-   `IDirect3D9 * Direct3DCreate9(UINT SDKVersion);`  
  
-   `HRESULT Direct3DCreate9Ex(UINT SDKVersion, IDirect3D9Ex **ppD3D);`  
  
 В Windows Vista или более поздней версии операционной системы, используйте `Direct3DCreate9Ex` метод с отображением, который настроен для использования Windows отображения Driver Model (WDDM). Используйте `Direct3DCreate9` метод на любой другой платформы.  
  
### <a name="availability-of-the-direct3dcreate9ex-method"></a>Доступность метода Direct3DCreate9Ex  
 Имеет d3d9.dll `Direct3DCreate9Ex` метод только в Windows Vista или более поздней версии операционной системы. При прямой ссылке на эту функцию в Windows XP, приложение не удается загрузить. Чтобы определить, является ли `Direct3DCreate9Ex` метод поддерживается, загрузить библиотеку DLL и найдите адрес процедуры. Ниже показано, как проверить `Direct3DCreate9Ex` метод. Полный пример кода, см. в разделе [Пошаговое руководство: Создание содержимого Direct3D9 для размещения в WPF](walkthrough-creating-direct3d9-content-for-hosting-in-wpf.md).  
  
   
  
### <a name="hwnd-creation"></a>Создание HWND  
 Для создания устройства требуется HWND. Как правило вы создадите фиктивный HWND для использования Direct3D9. В следующем примере кода показано, как создать вспомогательный HWND.  
  
   
  
### <a name="present-parameters"></a>Представление параметров  
 Для создания устройства также требуется `D3DPRESENT_PARAMETERS` структуры, но только некоторые параметры являются важными. Эти параметры выбраны, чтобы свести к минимуму объем памяти.  
  
 Задайте `BackBufferHeight` и `BackBufferWidth` поля 1. Задавая для них значение 0 приводит к их будет присвоено размеры HWND.  
  
 Всегда значение `D3DCREATE_MULTITHREADED` и `D3DCREATE_FPU_PRESERVE` флаги, чтобы предотвратить повреждение памяти, используемой Direct3D9 и чтобы предотвратить изменение параметров FPU Direct3D9.  
  
 Ниже показано, как инициализировать `D3DPRESENT_PARAMETERS` структуры.  
  
   
  
## <a name="creating-the-back-buffer-render-target"></a>Создание целевого объекта отрисовки заднего буфера  
 Для отображения содержимого Direct3D9 в <xref:System.Windows.Interop.D3DImage>, можно создать поверхность Direct3D9 и назначить его путем вызова <xref:System.Windows.Interop.D3DImage.SetBackBuffer%2A> метод.  
  
### <a name="verifying-adapter-support"></a>Проверка поддержки адаптера  
 Прежде чем создавать рабочую область, убедитесь, что все адаптеры поддерживает свойства поверхности. Даже если при подготовке к просмотру только один адаптер, окно WPF могут отображаться на одном адаптере в системе. Следует всегда писать код Direct3D9, который обрабатывает конфигурацию с несколькими адаптерами и следует проверить все адаптеры для поддержки, так как WPF может перемещать поверхность среди доступных адаптеров.  
  
 В следующем примере кода показано, как проверить, поддерживают все адаптеры для Direct3D9 в системе.  
  
   
  
### <a name="creating-the-surface"></a>Создание рабочей области  
 Прежде чем создавать рабочую область, убедитесь, что возможности устройства поддерживает высокую производительность в целевой операционной системе. Дополнительные сведения см. в разделе [рекомендации по ускорению взаимодействием Direct3D9 и WPF](performance-considerations-for-direct3d9-and-wpf-interoperability.md).  
  
 После проверки возможности устройства, можно создать области. В следующем примере кода показано, как создать мишень рендеринга.  
  
   
  
### <a name="wddm"></a>WDDM  
 В Windows Vista и более поздних операционных системах, которые настроены на использование модели WDDM, можно создать текстуру целевой объект отрисовки и передать в область уровня 0, чтобы <xref:System.Windows.Interop.D3DImage.SetBackBuffer%2A> метод. Этот подход не рекомендуется в операционной системе Windows XP, поскольку не удается создать текстуру целевого блокируемый отрисовки и производительность будет снижена.  
  
## <a name="handling-device-state"></a>Обработка состояния устройства  
 <xref:System.Windows.Interop.D3DImage> Класс управляет двумя буферами отображения, которые называются *задний буфер* и *передний буфер*. Задний буфер — это область Direct3D.  Изменения на задний буфер копируются передний буфер при вызове <xref:System.Windows.Interop.D3DImage.Unlock%2A> метода, в котором они отображаются на оборудовании. В некоторых случаях передний буфер становится недоступной. Отсутствие доступности может быть вызвано блокировки экрана, весь экран эксклюзивные приложения Direct3D, переключения пользователей или другие системные события. В этом случае приложение WPF уведомляется путем обработки <xref:System.Windows.Interop.D3DImage.IsFrontBufferAvailableChanged> событий.  Как приложение реагирует на передний буфер, недоступности зависит от того, включен ли WPF на переключение на программную отрисовку. <xref:System.Windows.Interop.D3DImage.SetBackBuffer%2A> Метод имеет перегрузку, которая принимает параметр, который указывает, возвращается ли WPF к программной отрисовке.  
  
 При вызове <xref:System.Windows.Interop.D3DImage.SetBackBuffer%28System.Windows.Interop.D3DResourceType%2CSystem.IntPtr%29> перегружать или вызвать <xref:System.Windows.Interop.D3DImage.SetBackBuffer%28System.Windows.Interop.D3DResourceType%2CSystem.IntPtr%2CSystem.Boolean%29> перегрузка с `enableSoftwareFallback` параметру присвоить `false`, система отрисовки освобождает ссылку на задний буфер, если передний буфер становится недоступной, и ничего не отображается. Когда передний буфер снова станет доступным, система отрисовки вызывает <xref:System.Windows.Interop.D3DImage.IsFrontBufferAvailableChanged> событие для уведомления приложения WPF.  Можно создать обработчик событий для <xref:System.Windows.Interop.D3DImage.IsFrontBufferAvailableChanged> событие, чтобы перезапустить отрисовки с допустимым поверхность Direct3D. Чтобы перезапустить подготовки отчетов, необходимо вызвать <xref:System.Windows.Interop.D3DImage.SetBackBuffer%2A>.  
  
 При вызове <xref:System.Windows.Interop.D3DImage.SetBackBuffer%28System.Windows.Interop.D3DResourceType%2CSystem.IntPtr%2CSystem.Boolean%29> перегрузка с `enableSoftwareFallback` параметру присвоить `true`, система отрисовки сохраняет ссылку на задний буфер, если передний буфер становится недоступным, поэтому нет необходимости вызывать <xref:System.Windows.Interop.D3DImage.SetBackBuffer%2A> при переднего плана буфер снова станет доступным.  
  
 При включенной программного обеспечения отрисовки, могут возникнуть ситуации, на устройстве пользователя становится недоступной, когда система отрисовки сохраняет ссылку на поверхность Direct3D. Чтобы проверить, является ли устройство Direct3D9 недоступен, вызовите `TestCooperativeLevel` метод. Чтобы проверить вызов Direct3D9Ex устройств `CheckDeviceState` метод, так как `TestCooperativeLevel` метод является устаревшим и всегда завершается успешно. Если устройство пользователя стала недоступной, вызовите <xref:System.Windows.Interop.D3DImage.SetBackBuffer%2A> для освобождения WPF ссылку на задний буфер.  Если вам потребуется выполнить сброс устройства, вызвать <xref:System.Windows.Interop.D3DImage.SetBackBuffer%2A> с `backBuffer` параметру присвоить `null`и затем вызвать <xref:System.Windows.Interop.D3DImage.SetBackBuffer%2A> с `backBuffer` присвоено допустимое поверхность Direct3D.  
  
 Вызовите `Reset` способ устранения неработающего устройства только в том случае, если реализована поддержка нескольких адаптеров. В противном случае — освобождает все интерфейсы Direct3D9 и заново создайте их полностью. Если разметка адаптера был изменен, Direct3D9 объекты, созданные до изменения не обновляются.  
  
## <a name="handling-resizing"></a>Обработка изменения размера  
 Если <xref:System.Windows.Interop.D3DImage> отображается с разрешением, отличный от исходного размера, оно масштабируется в соответствии с текущим <xref:System.Windows.Media.RenderOptions.BitmapScalingMode%2A>, за исключением того, что <xref:System.Windows.Media.Effects.SamplingMode.Bilinear> заменяется <xref:System.Windows.Media.BitmapScalingMode.Fant>.  
  
 Если требуется более высокая точность, необходимо создать новую поверхность, когда контейнер <xref:System.Windows.Interop.D3DImage> изменяется размер.  
  
 Существует три способа обработки изменения размера.  
  
-   Участвовать в системе макета и создайте новую поверхность, при изменении размера. Не создавайте слишком много рабочих областей, так как можно израсходовать или фрагментировать память.  
  
-   Подождите, пока событие изменения размера не произошло за фиксированный период времени для создания новой рабочей области.  
  
-   Создание <xref:System.Windows.Threading.DispatcherTimer> , проверять размеры контейнера несколько раз в секунду.  
  
## <a name="multi-monitor-optimization"></a>Оптимизация конфигураций с несколькими мониторами  
 Значительное снижение производительности может произойти при перемещении система отрисовки <xref:System.Windows.Interop.D3DImage> на другой монитор.  
  
 В WDDM пока мониторы находятся на том же видео карте и используется `Direct3DCreate9Ex`, имеется без снижения производительности. Если мониторы используют разные видео карты, производительность снижается. В Windows XP производительность снижается всегда.  
  
 Когда <xref:System.Windows.Interop.D3DImage> перемещается на другой монитор, можно создать новую поверхность на соответствующий адаптер, чтобы восстановить хорошую производительность.  
  
 Чтобы избежать снижения производительности, напишите код, специально для случая нескольких мониторов. Ниже показан один способ написания кода для нескольких мониторов.  
  
1. Найти точку <xref:System.Windows.Interop.D3DImage> в пространстве экрана с `Visual.ProjectToScreen` метод.  
  
2. Используйте `MonitorFromPoint` GDI-способ найти монитор, отображающий эту точку.  
  
3. Используйте `IDirect3D9::GetAdapterMonitor` метод, чтобы найти адаптер Direct3D9 монитор включен.  
  
4. Если адаптер не так же, как адаптер с задним буфером, создайте новый задний буфер для нового монитора и назначьте его <xref:System.Windows.Interop.D3DImage> задний буфер.  
  
> [!NOTE]
>  Если <xref:System.Windows.Interop.D3DImage> распределяется между несколькими мониторами, производительность будет снижена, за исключением использования WDDM и `IDirect3D9Ex` в одном адаптере. Нет способа для повышения производительности в этой ситуации.  
  
 В следующем примере кода показано, как найти текущего монитора.  
  
   
  
 Обновление монитора при <xref:System.Windows.Interop.D3DImage> изменения размера или положения контейнера или обновите монитор с помощью `DispatcherTimer` , обновляет несколько раз в секунду.  
  
## <a name="wpf-software-rendering"></a>WPF программной отрисовки  
 WPF выполняет визуализацию синхронно в потоке пользовательского интерфейса в программном обеспечении в следующих ситуациях.  
  
-   Печать  
  
-   <xref:System.Windows.Media.Effects.BitmapEffect>  
  
-   <xref:System.Windows.Media.Imaging.RenderTargetBitmap>  
  
 При возникновении такой ситуации система отрисовки вызывает <xref:System.Windows.Interop.D3DImage.CopyBackBuffer%2A> метод копирования в буфер оборудования к программному обеспечению. По умолчанию реализация вызывает `GetRenderTargetData` метод с вашей рабочей областью. Так как этот вызов происходит вне шаблона блокирования и разблокирования, он может завершиться ошибкой. В этом случае `CopyBackBuffer` возвращает метод `null` и изображение не отображается.  
  
 Можно переопределить <xref:System.Windows.Interop.D3DImage.CopyBackBuffer%2A> метода, вызвать базовую реализацию, и если он возвращает `null`, можно вернуть заполнитель <xref:System.Windows.Media.Imaging.BitmapSource>.  
  
 Вы также можете реализовать собственные программную отрисовку вместо того чтобы вызывать базовую реализацию.  
  
> [!NOTE]
>  Если WPF выполняет отрисовку полностью в программном обеспечении, <xref:System.Windows.Interop.D3DImage> не указывается, так как WPF нет передний буфер.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Interop.D3DImage>
- [Вопросы производительности, связанные с взаимодействием Direct3D9 и WPF](performance-considerations-for-direct3d9-and-wpf-interoperability.md)
- [Пошаговое руководство. Создание содержимого Direct3D9 для размещения в WPF](walkthrough-creating-direct3d9-content-for-hosting-in-wpf.md)
- [Пошаговое руководство. Размещение содержимого Direct3D9 в WPF](walkthrough-hosting-direct3d9-content-in-wpf.md)
