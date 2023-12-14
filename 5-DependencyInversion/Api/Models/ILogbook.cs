using System.Text;

namespace DependencyInversion
{
    public interface ILogbook
    {
        public void Add(string description);
    }
}