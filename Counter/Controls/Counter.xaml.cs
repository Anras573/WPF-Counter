using System.Windows.Controls;
using Counter.ViewModels;

namespace Counter.Controls;

public partial class Counter : UserControl
{
    public Counter()
    {
        InitializeComponent();
        DataContext = new CounterViewModel();
    }
}