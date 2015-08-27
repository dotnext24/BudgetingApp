using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace WebUI.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsActive { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("BudgetingAppDBContext")
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountLevel> AccountLevels { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }
    }
}