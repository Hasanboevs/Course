using Course.Domain.Entities;
namespace Course.Infrastructure.IRepositories;
public interface ICourseRepository
{
	Cours GetById(int id);
	void Save(Cours course);
	void Delete(Cours course);
}
