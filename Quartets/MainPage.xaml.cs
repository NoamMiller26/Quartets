using Quartets.ViewModels;

namespace Quartets
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM();
        }        
    }
}
