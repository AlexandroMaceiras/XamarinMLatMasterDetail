using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavigationPages.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void MudarPagina1(object o, EventArgs e)
        {
            Detail = new TipoPagina.Navigation.Pagina1();
            IsPresented = false; //Fecha o menu.
        }

        private void MudarPagina2(object o, EventArgs e)
        {
            Detail = new NavigationPage(new TipoPagina.Navigation.Pagina2());
            IsPresented = false;
        }

        private void MudarPagina3(object o, EventArgs e)
        {
            Detail = new Conteudo();
            IsPresented = false;
        }
    }
}