using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContrlolAVS.Model;

namespace DataContrlolAVS.WebService
{
    public interface IRequestSensorData
    {
        IEnumerable<SensorData> GetSensorData();
    }
}
