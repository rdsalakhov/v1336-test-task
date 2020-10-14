using System.IO;
using Newtonsoft.Json;

namespace DeviceConflict
{
    public class JsonConflictWriter : IConflictWriter
    {
        private readonly string _path;

        public JsonConflictWriter(string path)
        {
            this._path = path;
        }
        
        public void WriteConflicts(Conflict[] conflicts)
        {
            using (StreamWriter w = new StreamWriter(_path))
            {
                string conflictsString = JsonConvert.SerializeObject(conflicts, Formatting.Indented);
                w.Write(conflictsString);
            }
        }
    }
}