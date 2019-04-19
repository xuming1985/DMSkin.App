using System.Windows;

namespace Animation.Common
{
    public interface ICommandProxy
    {
        object GetCommandOwner(DependencyObject source);
    }
}
