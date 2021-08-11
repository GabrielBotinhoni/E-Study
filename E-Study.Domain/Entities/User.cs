using System;
using System.Collections.Generic;
using System.Text;

namespace E_Study.Domain.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool Enabled { get; set; }
        public UserType userType { get; set; }
    }

    public enum UserType
    {
        Administrator,
        Teacher,
        Student
    }
}
