using System.Windows.Input;
using Counter.Framework;
using Counter.Models;

namespace Counter.ViewModels;

public class CounterViewModel
{
    public CounterModel CounterModel { get; } = new();
    public ICommand IncrementCommand => new RelayCommand(Increment, CanIncrement);
    
    private void Increment()
    {
        CounterModel.Count++;
    }
    
    private bool CanIncrement() => CounterModel.Count < 10;
}