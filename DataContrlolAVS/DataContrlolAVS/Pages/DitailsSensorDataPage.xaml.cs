using DataContrlolAVS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContrlolAVS.Infrastructures;
using Xamarin.Forms;
using DataContrlolAVS.Model;

namespace DataContrlolAVS.Pages
{
    public partial class DitailsSensorDataPage : ContentPage
    {


        public DitailsSensorDataPage()
        {
            InitializeComponent();
            //   Content=(new View1(new[] { new CustomPoint { X = 10, Y = 20 }, new CustomPoint { X = 20, Y = 40 }, new CustomPoint { X = 30, Y =30 }, new CustomPoint { X = 50, Y = 20 }, }));
            Content = new GraphicsView();
        }

     

        public DitailsSensorDataPage(IEnumerable<Model.SensorData> sensorDataCollection):this()
        {
            DateTime currentTime = DateTime.Now;
            var sensorDataLast = sensorDataCollection.Where(sdl => sdl.ReciveTime.AddMinutes(1) > currentTime);

            // tListView.ItemsSource = sensorDataLast.Select(l => l.CurrentTemperature.ToString());
            GraphicsView gWiew = (GraphicsView)Content;
            List<CustomPoint> cPints = new List<CustomPoint>();
            int x = 50;
            foreach (SensorData sensorData in sensorDataLast)
            {
                cPints.Add(new CustomPoint() { X = x, Y =(int) sensorData.CurrentTemperature });
                x += 40;

            }
            gWiew.TemperatureData = cPints;

        }

       
    }
}
