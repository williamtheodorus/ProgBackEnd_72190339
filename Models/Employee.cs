using System;

namespace BackendLatihanBlazor.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gen { get; set; }
        public Department Depart { get; set; }
        public string PhotoPath { get; set; }
    }

    public enum Gender{
        Male,Female
    }
}