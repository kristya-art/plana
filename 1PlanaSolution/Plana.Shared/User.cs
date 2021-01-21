using Plana.Shared;
using System.ComponentModel.DataAnnotations;

namespace Plana.Shared
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

        public RoleDto Role { get; set; }
    }
}
