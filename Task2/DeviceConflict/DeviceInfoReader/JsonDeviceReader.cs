using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DeviceConflict
{
    public class JsonDeviceReader : IDeviceReader
    {
        private readonly string _path;

        public JsonDeviceReader(string path)
        {
            this._path = path;
        }


        public DeviceInfo[] ReadDeviceInfo()
        {
            List<DeviceInfo> deviceInfoList;
            using (StreamReader r = new StreamReader(_path))
            {
                string json = r.ReadToEnd();
                deviceInfoList = JsonConvert.DeserializeObject<List<DeviceInfo>>(json);
            }

            return deviceInfoList.ToArray();
        }
    }
}