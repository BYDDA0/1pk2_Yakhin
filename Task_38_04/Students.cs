using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_38_04
{
    class Students
    {
        private List<Student> students = new();
        public List<Student> StudentsList => students;
        private string fileName = "studentsSaveFile";
        public void AddStudent(Student student)
        {
            if (student != null)
            {
                students.Add(student);
                students.Sort();
            }
        }
        public void RemoveStudent(Student student)
        {
            if (students.Contains(student))
            {
                students.Remove(student);
            }
        }

        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            var seriolizion = JsonSerializer.Serialize(students, options);
            File.WriteAllText(fileName, seriolizion);
        }

        public void Load()
        {
            if (!File.Exists(fileName))
                return;
            var data = File.ReadAllText(fileName);
            if (data != null)
                students = JsonSerializer.Deserialize<List<Student>>(data);
            else students = new List<Student>();
        }
    }
}
