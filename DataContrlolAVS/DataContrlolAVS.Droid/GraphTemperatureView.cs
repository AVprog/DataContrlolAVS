using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace DataContrlolAVS.Droid
{
    public class GraphTemperatureView : View
    {
        IEnumerable<DataContrlolAVS.Infrastructures.CustomPoint> data;

        public GraphTemperatureView(Context context) : base(context)
        {

        }
        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            canvas.DrawLine(50, 600, 700, 600, new Paint() { Color = Android.Graphics.Color.Blue, StrokeWidth = 1 });
            canvas.DrawLine(50, 600, 50, 50, new Paint() { Color = Android.Graphics.Color.Blue, StrokeWidth = 1 });
            canvas.DrawText("time", 720, 620, new Paint() { Color = Android.Graphics.Color.Blue, StrokeWidth = 150 });


            foreach (var point in data)
            {
                canvas.DrawPoint(point.X+50,(600-point.Y*10), new Paint() { Color = Android.Graphics.Color.Red, StrokeWidth = 30 });

            }
            canvas.Save();
        }

        public void SetTemperatureData(IEnumerable<DataContrlolAVS.Infrastructures.CustomPoint> data)
        {
            this.data = data;
            Invalidate();

        }

    }
}