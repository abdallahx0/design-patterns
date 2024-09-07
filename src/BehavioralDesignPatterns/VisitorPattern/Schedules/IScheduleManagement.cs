using VisitorPattern.Visitors;

namespace VisitorPattern.Schedules
{
    public interface IScheduleManagement
    {
        void GenerateReport();
        void CalculateOverTime();
        void Accept(IScheduleManagementVisitor scheduleManagementVisitor);
    }

}
