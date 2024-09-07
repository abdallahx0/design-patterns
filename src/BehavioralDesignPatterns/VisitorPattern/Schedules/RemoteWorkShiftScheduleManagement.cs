using VisitorPattern.Visitors;

namespace VisitorPattern.Schedules
{
    public class RemoteWorkShiftScheduleManagement : IScheduleManagement
    {
        public void Accept(IScheduleManagementVisitor scheduleManagementVisitor)
            => scheduleManagementVisitor.Visit(this);

        public void CalculateOverTime()
            => Console.WriteLine("Calculating over time for remote shift..");

        public void GenerateReport()
            => Console.WriteLine("Generating report for remote shift...");
    }
}
