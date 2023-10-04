using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AuthSystems.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
	[PersonalData]
	[Column(TypeName = "nvarchar(100)")]
	public string FirstName { get; set; }

	[PersonalData]
	[Column(TypeName = "nvarchar(100)")]
	public string LastName { get; set; }

	[Display(Name = "Email")]
	public string Email { get; set; }


	[Display(Name = "UserId")]
    public string UserId { get; set; }

    [Display(Name = "Phone Number")]
	public virtual string? PhoneNumber { get; set; }


	public string Gender { get; set; }

    public string MaritalStatus { get; set; }

   

    //public string SelectedIdentificationType { get; set; }

    //public string IdentificationNumber { get; set; }



    //public string UserId { get; set; } = Guid.NewGuid().ToString().Substring(0, 4);
    
}

