using VisitorPattern.Visitors;

namespace VisitorPattern.Schedules
{
    public class DayShiftScheduleManagement : IScheduleManagement
    {
        public void Accept(IScheduleManagementVisitor scheduleManagementVisitor)
            => scheduleManagementVisitor.Visit(this);

        public void CalculateOverTime()
            => Console.WriteLine("Calculating over time for day shift..");

        public void GenerateReport()
            => Console.WriteLine("Generating report for day shift...");
    }
}
