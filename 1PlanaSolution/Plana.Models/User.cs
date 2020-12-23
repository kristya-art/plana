
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Plana.Models
{
    public abstract class User : PlanaEntity
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }
     
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        public string Token { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
