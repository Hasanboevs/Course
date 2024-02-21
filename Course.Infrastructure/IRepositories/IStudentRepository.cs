using Course.Domain.Entities;

namespace Course.Infrastructure.IRepositories;

public interface IStudentRepository
{
	Student GetById(int id);
	void Save(Student student);
	void Delete(Student student);
}
