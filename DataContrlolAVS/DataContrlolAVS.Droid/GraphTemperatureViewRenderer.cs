using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Util;
using Android.Widget;
using DataContrlolAVS.Droid;
using Android.Graphics;
using DataContrlolAVS.Pages;

[assembly: ExportRenderer(typeof(GraphicsView), typeof(GraphTemperatureViewRenderer))]
namespace DataContrlolAVS.Droid
{

    class GraphTemperatureViewRenderer : ViewRenderer<GraphicsView, GraphTemperatureView>
    {

        protected override void OnElementChanged(ElementChangedEventArgs<GraphicsView> args)
        {
            base.OnElementChanged(args);
            if (Control == null)
            {
                SetNativeControl(new GraphTemperatureView(Context));
            }
            if(args.NewElement!=null)
            {
                Control.SetTemperatureData(Element.TemperatureData);
            }

            
        }

        protected override void OnDraw(Canvas canvas)
        {
            //base.OnDraw(canvas);
            //canvas.DrawLine(0, 0, 300, 300, new Paint() { Color = Android.Graphics.Color.Red, StrokeWidth = 5 });
            //canvas.DrawRect(new Rect(10, 20, 30, 40), new Paint { Color = Android.Graphics.Color.Blue, StrokeWidth = 2 });
            //canvas.Save();
        }



    }
}