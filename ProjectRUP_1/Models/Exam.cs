//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectRUP_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        public Exam()
        {
            this.Evaluation = new HashSet<Evaluation>();
            this.ExamClassroom = new HashSet<ExamClassroom>();
            this.ExamSubscription = new HashSet<ExamSubscription>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Creator { get; set; }
        public string Speciality { get; set; }
        public bool ComputerNeeded { get; set; }
        public int Surveillant { get; set; }
        public int ExpectedStudents { get; set; }
        public bool ResultIsDecimal { get; set; }
        public int QuarterId { get; set; }
        public int MinutesDuration { get; set; }
    
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual User User { get; set; }
        public virtual Quarter Quarter { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<ExamClassroom> ExamClassroom { get; set; }
        public virtual ICollection<ExamSubscription> ExamSubscription { get; set; }
    }
}
