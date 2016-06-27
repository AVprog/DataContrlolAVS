using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContrlolAVS.Model;

namespace DataContrlolAVS.DAL
{
 public   class SensorDataRepository : ISensorDataRepository
    {
        static List<SensorData> allSensorData = new List<SensorData>();

        public  void AddSensorData(IEnumerable<SensorData> sensorDataCollection)
        {
            allSensorData.AddRange(sensorDataCollection);
        }

        public  IEnumerable<SensorData> GetAllSensorData()
        {
            return allSensorData;
        }

        public IEnumerable<SensorData> GetSensorDataByName(string sensorName)
        {
            return allSensorData.Where(snl => snl.SensorName == sensorName).ToArray();
        }
    }
}
