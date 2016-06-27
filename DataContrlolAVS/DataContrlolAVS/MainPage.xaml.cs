using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataContrlolAVS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel.MainPageViewModel(new WebService.RequestSensorDataTest(),new DAL.SensorDataRepository(),this);
            
        }

        async void DitailsPageView_Click(object sender, EventArgs e)
        {

        }
    }
}
