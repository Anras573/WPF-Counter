using System.Windows.Input;
using Counter.Framework;
using Counter.Models;

namespace Counter.ViewModels;

public class CounterViewModel : BindableBase
{
    private readonly CounterModel _model = new();
    public ICommand IncrementCommand => new RelayCommand(Increment, CanIncrement);

    private void Increment()
    {
        _model.Count++;
        OnPropertyChanged(nameof(CounterText));
    }
    private bool CanIncrement() => _model.Count < 10;

    public string CounterText
    {
        get
        {
            var padding = _model.Count is 1 ? "time" : "times";
            
            return $"You clicked {_model.Count} {padding}";
        }
    }
}