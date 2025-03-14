using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace bai3.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    private String FullName { get; set; }
    public String? Address { get; set; }
    public String? Age { get; set; }
}