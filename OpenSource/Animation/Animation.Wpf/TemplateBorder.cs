using System.Windows;
using System.Windows.Controls;

namespace Animation.Wpf
{
    public class TemplateBorder : Border
    {
        static TemplateBorder()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TemplateBorder), new FrameworkPropertyMetadata(typeof(TemplateBorder)));
        }
    }
}
