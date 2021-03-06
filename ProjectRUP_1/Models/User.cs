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
    
    public partial class User
    {
        public User()
        {
            this.Evaluation = new HashSet<Evaluation>();
            this.Exam = new HashSet<Exam>();
            this.Exam1 = new HashSet<Exam>();
            this.ExamSubscription = new HashSet<ExamSubscription>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Insertion { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
    
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual ICollection<Exam> Exam { get; set; }
        public virtual ICollection<Exam> Exam1 { get; set; }
        public virtual ICollection<ExamSubscription> ExamSubscription { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
