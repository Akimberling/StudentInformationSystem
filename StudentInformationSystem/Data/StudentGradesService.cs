using System;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSystem.Data
{
    public class StudentGradesService
    {
        private static readonly string[] Classes = new[]
        {
            "Chemistry", "Biology", "Physics", "History", "English"
        };

        public Task<Class[]> GetGradesAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Class
            {
                ClassName = Classes[rng.Next(Classes.Length)],
                Description = "Intro Class",
                Units = rng.Next(3, 5),
                Grade = rng.NextDouble() + 3.0
            }).ToArray());
        }
    }
}
