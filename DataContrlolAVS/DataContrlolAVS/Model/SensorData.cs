using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataContrlolAVS.Model
{
    public class SensorData : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string SensorName { get; set; }
        //public StateType SensorState { get; set; }
        private StateType sensorState;

        public StateType SensorState
        {
            get { return sensorState; }
            set { sensorState = value;
                OnPropertyChanged(nameof(SensorState));
            }
        }

        //     public double CurrentTemperature { get; set; }
        private double currentTemperature;

        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set
            {
                currentTemperature = value;
                OnPropertyChanged(nameof(CurrentTemperature));
            }
        }

        public double MaxTemperature { get; set; }
        public double MinTemperature { get; set; }
        public DateTime ReciveTime { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public enum StateType
    {
        On,
        Off,
        Broken,
        Unknown
    }
}
