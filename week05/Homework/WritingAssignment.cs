using System;

class Program
{
    public class Employee
    {
        private string salary  = "$100";

        public float CalculatePay()
        {
            return salary;
        }
    }

    public class hourlyEmployee : Employee
    {
        private float rate = 9f;
        private float hour = 100f;

        public override float CalculatePay()
        {
            return rate*hour;
        }
    }
}