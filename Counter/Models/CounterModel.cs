using Counter.Framework;

namespace Counter.Models;

public class CounterModel : BindableBase
{
    private int _count;
    public int Count
    {
        get => _count;
        set => SetField(ref _count, value);
    }
}