

namespace Course.Domain.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CourseId { get; set;}
    public string Course { get; set; }
}
