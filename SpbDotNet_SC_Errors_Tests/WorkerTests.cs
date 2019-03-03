using System;
using SpbDotNet_SC_Errors;
using Xunit;

namespace SpbDotNet_SC_Errors_Tests
{
    public class WorkerTests
    {
        [Fact]
        public void GetCountSum_Test()
        {
            var ps = new Person { FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1990, 1, 1) };
            var pf = new Profession { Name = "DevOps engineer", Description = "Do all of the stuff you need" };

            var result = Worker.GetPersonProfession(ps, pf);
            Assert.Equal(result, $"{ps.FirstName} {ps.LastName} ({ps.BirthDate}) is a {pf.Name}");
        }
    }
}
