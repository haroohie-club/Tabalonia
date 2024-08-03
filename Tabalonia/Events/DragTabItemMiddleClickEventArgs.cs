using Tabalonia.Controls;

namespace Tabalonia.Events
{
    public class DragTabItemMiddleClickEventArgs : DragTabItemEventArgs
    {
        public DragTabItemMiddleClickEventArgs(DragTabItem dragTabItem) : base(dragTabItem)
        {
        }

        public DragTabItemMiddleClickEventArgs(RoutedEvent routedEvent, DragTabItem dragTabItem) : base(routedEvent, dragTabItem)
        {
        }
    }
}
