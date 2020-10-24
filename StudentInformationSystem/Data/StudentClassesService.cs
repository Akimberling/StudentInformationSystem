using System;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSystem.Data
{
    public class StudentClassesService
    {
        private static readonly string[] ClassNames = new[]
        {
            "Chemistry", "Biology", "Physics", "History", "English"
        };

        private static readonly string[] Names = new[]
        {
            "Bob", "Jane", "Jill", "Greg", "Clark"
        };

        public Task<Student[]> GetStudentsAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Student
            {
                Name = Names[rng.Next(Names.Length)],
                Classes = null

            }).ToArray());
        }
    }
}
