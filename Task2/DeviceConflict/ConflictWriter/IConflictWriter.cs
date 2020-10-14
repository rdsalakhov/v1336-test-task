namespace DeviceConflict
{
    public interface IConflictWriter
    {
        void WriteConflicts(Conflict[] conflicts);
    }
}