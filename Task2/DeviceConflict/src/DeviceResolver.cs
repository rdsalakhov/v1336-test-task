using System.Linq;

namespace DeviceConflict
{
    public class DeviceResolver
    {
        public void Resolve(IDeviceReader deviceReader, IConflictWriter conflictWriter)
        {
            var deviceInfo = deviceReader.ReadDeviceInfo();
            var groups = deviceInfo.GroupBy(d => d.Brigade.Code)
                .Where(g => g.Count() > 1 && g.Any(d => d.Device.IsOnline));
                
            var conflicts = groups.Select(g => new Conflict
            {
                BrigadeCode = g.Key,
                DevicesSerials = g.Select(d => d.Device.SerialNumber).ToArray()
            }).ToArray();
            
            conflictWriter.WriteConflicts(conflicts);
        }
    }
}