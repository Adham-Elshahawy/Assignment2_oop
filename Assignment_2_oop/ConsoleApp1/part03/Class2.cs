using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.part03
{
    //#region with property 
    //public enum SecurityLevel
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA
    //}

    //public struct HiringDate
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }


    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //public class Employee
    //{

    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    private string gender;

    //    public string Gender
    //    {
    //        get { return gender; }
    //        set
    //        {
    //            if (value == "M" || value == "F")
    //                gender = value;
    //            else
    //                throw new ArgumentException("Gender must be 'M' or 'F'.");
    //        }
    //    }

    //    public SecurityLevel Security { get; set; }
    //    public decimal Salary { get; set; }
    //    public HiringDate HireDate { get; set; }

    //    // Constructor
    //    public Employee(int id, string name, string gender, SecurityLevel security, decimal salary, HiringDate hireDate)
    //    {
    //        ID = id;
    //        Name = name;
    //        Gender = gender;
    //        Security = security;
    //        Salary = salary;
    //        HireDate = hireDate;
    //    }


    //    public override string ToString()
    //    {
    //        return $"{Name}, ID: {ID}, Gender: {Gender}, Security: {Security}, Hire Date: {HireDate}, Salary: {string.Format(CultureInfo.InvariantCulture, "{0:C}", Salary)}";
    //    }
    //}
    //#endregion


    #region with getter and setter
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public class HiringDate
    {
        private int day;
        private int month;
        private int year;


        public int GetDay()
        {
            return day;
        }
        public void SetDay(int value)
        {
            if (value < 1 || value > 31)
                throw new ArgumentException("Day must be between 1 and 31.");
            day = value;
        }

        public int GetMonth()
        {
            return month;
        }
        public void SetMonth(int value)
        {
            if (value < 1 || value > 12)
                throw new ArgumentException("Month must be between 1 and 12.");
            month = value;
        }

        public int GetYear()
        {
            return year;
        }
        public void SetYear(int value)
        {
            if (value < 1900 || value > DateTime.Now.Year)
                throw new ArgumentException("Year must be valid and not in the future.");
            year = value;
        }

        // Constructor
        public HiringDate(int day, int month, int year)
        {
            SetDay(day);
            SetMonth(month);
            SetYear(year);
        }

        // Override ToString to display the date properly
        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }
    }

    public class Employee
    {
        private int id;
        private string name;
        private string gender;
        private SecurityLevel security;
        private decimal salary;
        private HiringDate hireDate;

        // Getters and Setters for each property
        public int GetID()
        {
            return id;
        }
        public void SetID(int value)
        {
            if (value <= 0)
                throw new ArgumentException("ID must be positive.");
            id = value;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            name = value;
        }

        public string GetGender()
        {
            return gender;
        }
        public void SetGender(string value)
        {
            if (value == "M" || value == "F")
                gender = value;
            else
                throw new ArgumentException("Gender must be 'M' or 'F'.");
        }

        public SecurityLevel GetSecurity()
        {
            return security;
        }
        public void SetSecurity(SecurityLevel value)
        {
            security = value;
        }

        public decimal GetSalary()
        {
            return salary;
        }
        public void SetSalary(decimal value)
        {
            if (value < 0)
                throw new ArgumentException("Salary must be non-negative.");
            salary = value;
        }

        public HiringDate GetHireDate()
        {
            return hireDate;
        }
        public void SetHireDate(HiringDate value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value), "Hire Date cannot be null.");
            hireDate = value;
        }

        // Constructor
        public  Employee (int id, string name, string gender, SecurityLevel security, decimal salary, HiringDate hireDate)
        {
            SetID(id);
            SetName(name);
            SetGender(gender);
            SetSecurity(security);
            SetSalary(salary);
            SetHireDate(hireDate);
        }


        public override string ToString()
        {
            return $"{GetName()}, ID: {GetID()}, Gender: {GetGender()}, Security: {GetSecurity()}, Hire Date: {GetHireDate()}, Salary: {string.Format(CultureInfo.InvariantCulture, "{0:C}", GetSalary())}";
        }
        #endregion



    }
}

