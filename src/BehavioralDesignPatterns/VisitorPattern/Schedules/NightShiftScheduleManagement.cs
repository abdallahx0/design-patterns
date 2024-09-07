using VisitorPattern.Visitors;

namespace VisitorPattern.Schedules
{
    public class NightShiftScheduleManagement : IScheduleManagement
    {
        public void Accept(IScheduleManagementVisitor scheduleManagementVisitor)
            => scheduleManagementVisitor.Visit(this);

        public void CalculateOverTime()
            => Console.WriteLine("Calculating over time for night shift..");

        public void GenerateReport()
            => Console.WriteLine("Generating report for night shift...");
    }
}
