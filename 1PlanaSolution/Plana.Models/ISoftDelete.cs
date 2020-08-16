using System;


namespace Plana.Models
{
    interface ISoftDelete
    {
        bool IsDeleted { get; set; }
        
       DateTime Delete_Date { get; set; }
    }
}
