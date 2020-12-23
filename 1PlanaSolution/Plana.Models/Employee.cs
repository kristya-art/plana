using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace Plana.Models
{
    public abstract class Employee : User
    //public abstract class Employee : IdentityUser
    {
        
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        //100%
        public double WorkingRate { get; set; }
        public bool IsActive { get; set; }
        //public DateTime ActiveTill = new DateTime(2030, 12, 31);
        public DateTime ActiveTill { get; set; }
       
       // public bool IsDeleted { get; set; }
        

       public int CalculateAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
        public abstract string DisplayData();
       
    }
}
