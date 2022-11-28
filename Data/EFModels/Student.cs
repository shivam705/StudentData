using System;
using System.Collections.Generic;

#nullable disable

namespace StudentData.Data.EFModels
{
    public partial class Student
    {
        public int Id { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public int Score { get; set; }
    }
}
