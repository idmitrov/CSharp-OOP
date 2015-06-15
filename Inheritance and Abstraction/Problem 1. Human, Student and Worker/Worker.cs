namespace Problem_1.Human__Student_and_Worker
{
    using System;

    class Worker : Human
    {
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHours()
        {
            return (this.WeekSalary / 7) / this.WorkHoursPerDay;
        }
    }
}
