using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContrlolAVS.Model;

namespace DataContrlolAVS.WebService
{
    class RequestSensorDataTest : IRequestSensorData
    {
        static int currentId = 1;

        readonly int maxRoomTemperature = 30;
        readonly int minRoomTemperature = 18;
        readonly int maxOutdorTemperature = 50;
        readonly int minOutdorTemperature = -30;



        public IEnumerable<SensorData> GetSensorData()
        {
            //// test data generation
            Random random = new Random();
            SensorData value1 = new SensorData()
            {
                Id = currentId++,
                SensorName = "Гостинная",
                CurrentTemperature = random.Next(minRoomTemperature, maxRoomTemperature),
                MaxTemperature = maxRoomTemperature,
                MinTemperature = minRoomTemperature,
                SensorState = StateType.On

            };
            SensorData value2 = new SensorData()
            {
                Id = currentId++,
                SensorName = "Душевая",
                CurrentTemperature = random.Next(minRoomTemperature, maxRoomTemperature),
                MaxTemperature = maxRoomTemperature,
                MinTemperature = minRoomTemperature,
                SensorState = StateType.Off
            };
            SensorData value3 = new SensorData()
            {
                Id = currentId++,
                SensorName = "Лоджия",
                CurrentTemperature = random.Next(minOutdorTemperature, maxOutdorTemperature),
                MaxTemperature = maxOutdorTemperature,
                MinTemperature = minOutdorTemperature,
                SensorState = StateType.On
            };
            SensorData value4 = new SensorData()
            {
                Id = currentId++,
                SensorName = "Гараж",
                CurrentTemperature = random.Next(minOutdorTemperature, maxOutdorTemperature),
                MaxTemperature = maxOutdorTemperature,
                MinTemperature = minOutdorTemperature,
                SensorState = StateType.On
            };
            if (random.Next(minOutdorTemperature, maxOutdorTemperature) % 3 == 0)// random data for SensorState
            { value4.SensorState = StateType.Broken; }

            SensorData value5 = new SensorData()
            {
                Id = currentId++,
                SensorName = "Улица",
                CurrentTemperature = random.Next(minOutdorTemperature, maxOutdorTemperature),
                MaxTemperature = maxOutdorTemperature,
                MinTemperature = minOutdorTemperature,
                SensorState = StateType.On
            };

            SensorData value6 = new SensorData()
            {
                Id = currentId++,
                SensorName = "Спальня",
                CurrentTemperature = random.Next(minRoomTemperature, maxRoomTemperature),
                MaxTemperature = maxRoomTemperature,
                MinTemperature = minRoomTemperature,
                SensorState = StateType.On
            };
            SensorData value7 = new SensorData()
            {
                Id = currentId++,
                SensorName = "Кухня",
                CurrentTemperature = random.Next(minRoomTemperature, maxRoomTemperature),
                MaxTemperature = maxRoomTemperature,
                MinTemperature = minRoomTemperature,
                SensorState = StateType.Off
            };
            return new[] { value1, value2, value3, value4, value5, value6, value7 };
        }
    }
}
