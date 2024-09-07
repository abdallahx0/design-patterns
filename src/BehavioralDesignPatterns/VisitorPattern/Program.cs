
using VisitorPattern.Schedules;
using VisitorPattern.Visitors;

List<IScheduleManagement> scheduleManagements = new List<IScheduleManagement>()
{
    new DayShiftScheduleManagement(),
    new NightShiftScheduleManagement(),
    new RemoteWorkShiftScheduleManagement(),
};

scheduleManagements.ForEach(schedule =>
{
    schedule.CalculateOverTime();
    schedule.Accept(new ManageLeaveRequestsVisitor());
    schedule.Accept(new CalculateBonusVisitor());
    schedule.GenerateReport();
});