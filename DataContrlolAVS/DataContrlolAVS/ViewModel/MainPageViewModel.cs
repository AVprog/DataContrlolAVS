using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DataContrlolAVS.WebService;
using DataContrlolAVS.Model;
using DataContrlolAVS.DAL;
using System.ComponentModel;

using Xamarin.Forms;
using System.Windows.Input;

namespace DataContrlolAVS.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        #region Bindeble Property
        public ObservableCollection<Model.SensorData> SensorDataList { get; set; } = new ObservableCollection<Model.SensorData>();
        public SensorData SelectedSensor { get; set; }    
        public ICommand DitailsSensorDataCommand { get; set; }
        #endregion

        IRequestSensorData iRequestSensorData;
        ISensorDataRepository iSensorDataRepository;
        ContentPage contentPage;

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        public MainPageViewModel(IRequestSensorData iRequestSensorData,ISensorDataRepository iSensorDataRepository, ContentPage contentPage)
        {
            this.iRequestSensorData = iRequestSensorData;
            this.iSensorDataRepository = iSensorDataRepository;
            this.contentPage = contentPage;

            requestDataFromWebService();
            Device.StartTimer(new TimeSpan(0, 0, minutes: 0, seconds: 5, milliseconds: 0), requestDataFromWebService);
            DitailsSensorDataCommand = new Command(async () =>
              {
                  await contentPage.Navigation.PushAsync(new DataContrlolAVS.Pages.DitailsSensorDataPage(iSensorDataRepository.GetSensorDataByName(SelectedSensor.SensorName)));
              });
        }


        bool requestDataFromWebService()
        {
            var sensorDataCollection = iRequestSensorData.GetSensorData();
            iSensorDataRepository.AddSensorData(sensorDataCollection);
           
            if (SensorDataList.Count == 0) //init of SensorDataList
            {
                SensorDataList.Clear();
                foreach (SensorData sensorData in sensorDataCollection)
                {
                    sensorData.ReciveTime = DateTime.Now;
                    SensorDataList.Add(sensorData);
                }
            }
            else
            {
                foreach (SensorData sensorData in sensorDataCollection)
                {
               
                    sensorData.ReciveTime = DateTime.Now;
                    SensorData oldSensorData=SensorDataList.FirstOrDefault(sdl => sdl.SensorName == sensorData.SensorName);
                    if (oldSensorData != null)
                    {


                        oldSensorData.CurrentTemperature = sensorData.CurrentTemperature;
                        oldSensorData.MaxTemperature = sensorData.MaxTemperature;
                        oldSensorData.MinTemperature = sensorData.MinTemperature;
                        oldSensorData.SensorState = sensorData.SensorState;
             
                    }
                }
            
            }
            return true;
        }


    }
}
