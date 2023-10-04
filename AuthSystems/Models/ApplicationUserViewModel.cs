using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthSystems.Models
{
    public class ApplicationUserViewModel
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]

        public string LastName { get; set; }

        [DisplayName("UserId")]
        public string UserId { get; set; }

        [DisplayName("Email")]
		public string Email { get; set; }

		[DisplayName("Phone Number")]
		public virtual string? PhoneNumber { get; set; }




		[DisplayName("Gender")]
		public string Gender { get; set; }


		[DisplayName("Marital Status")]

        public string MaritalStatus { get; set; }

        [DisplayName("Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
