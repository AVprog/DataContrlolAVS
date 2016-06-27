using DataContrlolAVS.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text; 

using Xamarin.Forms;

namespace DataContrlolAVS.Pages
{
    public class GraphicsView : View
    {
        public GraphicsView()
        {
            

        }
        public GraphicsView(IEnumerable<CustomPoint> pointCollection):this()
        {
            TemperatureData = pointCollection;
        }


        public static readonly BindableProperty TemperatureDataProperty = BindableProperty.Create("TemperatureData", typeof(IEnumerable<CustomPoint>), typeof(GraphicsView), null);


        public IEnumerable<CustomPoint> TemperatureData
        {
            set { SetValue(TemperatureDataProperty, value); }
            get { return (IEnumerable<CustomPoint>)GetValue(TemperatureDataProperty); }
        }
    }
}

    
