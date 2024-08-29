namespace ZKEACMS.Widget
{
    public class WidgetViewModel<T> where T : WidgetBase
    {
        public T Widget { get; set; }
    }
}
