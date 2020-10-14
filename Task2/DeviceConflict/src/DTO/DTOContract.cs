namespace DeviceConflict
{
    public class DeviceInfo
    {
        public Device Device { get; set; }
        public Brigade Brigade { get; set; }
    }

    public class Device
    {
        public string SerialNumber { get; set; }
        public bool IsOnline { get; set; }
    }

    public class Brigade
    {
        public string Code { get; set; }
    }

    public class Conflict
    {
        public string BrigadeCode { get; set; }
        public string[] DevicesSerials { get; set; }
    }
}