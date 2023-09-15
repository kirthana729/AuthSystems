using System;
using System.Collections.Generic;
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

	//public string UserId { get; set; } = Guid.NewGuid().ToString().Substring(0, 4);
	public string UserId { get; set; }
}

