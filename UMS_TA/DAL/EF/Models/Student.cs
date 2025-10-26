using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string BloodGroup { get; set; }
        public string Nationality { get; set; }
        
        public string Department { get; set; }
        public string Mobile { get; set; }
        public DateTime Birthday { get; set; }
        public string NID { get; set; }
        public string PresentAddress { get; set; }
        public string ParmanentAddress { get; set; }
        public virtual ICollection<FeedandSurvery> FeedandSurveries { get; set; }
        public ICollection<object> convocationRequests { get; internal set; }

        public Student()
        {
            FeedandSurveries = new List<FeedandSurvery>();
        }

        /* public virtual ICollection<ApplyThesis> ApplyTheses { get; set; }
         public Student()
         {
             ApplyTheses = new List<ApplyThesis>();
         }*/
        /*public virtual ICollection<AddRequestPaperPublish> AddRequestPaperPublishes { get; set; }
        public Student()
        {
            AddRequestPaperPublishes = new List<AddRequestPaperPublish>();
        }*/
    }
}
