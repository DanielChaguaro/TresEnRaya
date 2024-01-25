using TresEnRaya.ViewModels;
//using Windows.UI.Core;

namespace TresEnRaya.Views;

public partial class TicTacToeGamePage : ContentPage
{
	public TicTacToeGamePage()
	{
		InitializeComponent();
		this.BindingContext = new TicTacToeGamePageViewModel();
	}
}