using System.Collections.ObjectModel;

namespace DependencyInversion
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        public Student Add(Student student);
    }
}