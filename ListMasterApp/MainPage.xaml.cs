using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListMasterApp
{

    public partial class MainPage : ContentPage
    {
        int i = 0;


        List<string> lista_de_valor = new List<string>();
        void CheckList(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageMinhaLista(lista_de_valor));

        }

        void AddItem(object sender, System.EventArgs e)
        {
            lista_de_valor.Add("Item " + i.ToString().PadLeft(2, '0'));
            i++;
        }

        void AddTexto(object sender, System.EventArgs e)
        {
            lista_de_valor.Add(text.Text);
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
