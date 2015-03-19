using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private const int workDaysInWeek = 5;

        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double moneyPerDay = this.WeekSalary / workDaysInWeek;
            double moneyPerHour = moneyPerDay / this.WorkHoursPerDay;
            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("{0}, Money per hour: {1:F2}", base.ToString(), this.MoneyPerHour());
        }
    }
}
