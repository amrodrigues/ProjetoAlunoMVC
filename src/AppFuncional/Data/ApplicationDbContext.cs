using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppFuncional.Models;

namespace AppFuncional.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	    public DbSet<AppFuncional.Models.Aluno> Aluno { get; set; } 
	}
}
