using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ecobici
{
	public partial class MainPage : ContentPage
	{
        Datos datos;
        List<Todo> items;
        public MainPage()
		{
			InitializeComponent();
            datos = new Datos();
            RefreshData();
        }

        async void RefreshData()
        {
            items = await datos.GetTodoItemsAsync();
            Estaciones.ItemsSource = items.OrderBy(item => item.name).ThenBy(item => item.address).ToList();
        }
    }
}
