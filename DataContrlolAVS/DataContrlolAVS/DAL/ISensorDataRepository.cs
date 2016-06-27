using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContrlolAVS.DAL
{
   public  interface ISensorDataRepository
    {
        IEnumerable<Model.SensorData> GetAllSensorData();
        IEnumerable<Model.SensorData> GetSensorDataByName(string sensorName);
        void AddSensorData(IEnumerable<Model.SensorData> sensorDataCollection);


    }
}
