﻿using System;

namespace Plana.Shared
{
    public abstract class Employee : User
    {
        public DateTime BirthDate { get; set; }
        
        public GenderDto Gender { get; set; }
        
        // 100%
        public double WorkingRate { get; set; }
        
        public bool IsActive { get; set; }
        
        public DateTime ActiveTill { get; set; }

        public int CalculateAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
        
        public abstract string DisplayData();
    }
}
