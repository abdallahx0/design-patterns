using VisitorPattern.Schedules;

namespace VisitorPattern.Visitors
{
    public interface IScheduleManagementVisitor
    {
        void Visit(DayShiftScheduleManagement dayShiftScheduleManagement);
        void Visit(NightShiftScheduleManagement nightShiftScheduleManagement);
        void Visit(RemoteWorkShiftScheduleManagement remoteWorkShiftScheduleManagement);
    }
}
