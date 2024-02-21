namespace Course.Domain.Entities;

public class Cours
{
	public int Id { get; set; }
	public string CourseName { get; set; }
	public string Description { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public int StudentId { get; set; }
	public string Student { get; set; }
}
