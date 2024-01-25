
using TresEnRaya.Views;

namespace TresEnRaya
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            App.Current.MainPage = new TicTacToeGamePage();
        }
    }
}