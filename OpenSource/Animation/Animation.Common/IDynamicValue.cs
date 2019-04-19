using System;

namespace Animation.Common
{
    public interface IDynamicValue<T>
    {
        T Value { get; }
        event EventHandler ValueChanged;
    }
}
