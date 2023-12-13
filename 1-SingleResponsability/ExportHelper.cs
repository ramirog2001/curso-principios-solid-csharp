using System.Collections;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SingleResponsability
{
    public class ExportHelper
    {
        public void ExportStudents(IEnumerable<Student> students) 
        {
            StringBuilder sb = new();
            sb.AppendLine("Id;Fullname;Grades");
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
            File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
        }

        public void ExportGeneric<T>(IEnumerable<T> collection)
        {
            var props = typeof(T).GetProperties();

            StringBuilder header = new();

            foreach (var prop in props)
            {
                header.Append($"{prop.Name};");
            }

            StringBuilder csv = new();
            csv.AppendLine(header.ToString());


            foreach (var item in collection)
            {
                StringBuilder row = new();
                foreach (var prop in props)
                {
                    if(prop.PropertyType.GetInterfaces().Contains(typeof(IList)))
                    {
                        row.Append("[");
                        foreach (var subitem in (IList)(prop.GetValue(item)??new()))
                            row.Append($"{subitem.ToString()},");
                        row.Remove(row.Length-1, 1);
                        row.Append("];");
                    }    
                    else
                        row.Append($"{prop.GetValue(item)};");
                }

                csv.AppendLine(row.ToString());
            }
            File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{typeof(T).Name}.csv"), csv.ToString(), Encoding.Unicode);
        }
    }
}