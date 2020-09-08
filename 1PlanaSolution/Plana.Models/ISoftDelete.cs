using System;


namespace Plana.Models
{
    interface ISoftDelete
    {
        bool IsDeleted { get; set; }
        
       DateTime? DeletedAt{ get; set; }
    }
}
