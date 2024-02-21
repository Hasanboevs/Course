using Course.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Course.Infrastructure.Contexts;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	public DbSet<Student> Students { get; set; }
	public DbSet<Cours> Courses {  get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<AppDbContext>().HasData
		(
			new Student { Id = 1, Name = "Muhammadyusuf", Course = "Businnes Management", CourseId = 1},
			new Student { Id = 2, Name = "Javohir", Course = "Scrum", CourseId = 2}
		);

		modelBuilder.Entity<Cours>().HasData
		(
			new Cours { Id = 1, CourseName = "Businnes Management", Description = "0 to hero", Student = "Muhammadyusuf", StudentId = 1, StartDate =  DateTime.Now, EndDate = DateTime.Now.AddDays(90)},
			new Cours { Id = 2, CourseName = "Scrum", Description = "Full course", Student = "Javohir", StudentId = 2, StartDate =  DateTime.Now, EndDate = DateTime.Now.AddDays(30)}
		);
	}
}
