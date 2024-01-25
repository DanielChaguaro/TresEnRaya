using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya.Models
{
    public partial class TicTacToeModel : ObservableObject
    {
        public TicTacToeModel(int index)
        {
            this.Index = index;
        }
        public int Index {  get; set; }

        [ObservableProperty]
        private string _selectedText;

        //El jugador 0 sera x y el jugador 1 sera o
        public int? Player {  get; set; }
    }
}
