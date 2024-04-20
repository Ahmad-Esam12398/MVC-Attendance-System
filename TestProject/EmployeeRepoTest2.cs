

using Attendance_Management_System.Repos;
using Xunit;

namespace TestProject
{
    public class EmployeeRepoTest2
    {
        [Theory]
        [InlineData(1, 3, 0)]
        [InlineData(2, 3, 5)]
        [InlineData(4, 3, 15)]
        [InlineData(6, 3, 35)]
        [InlineData(10, 3, 90)]
        [InlineData(15, 3, 200)]
        public void CalculateReducedScoreForAbscenceWithPermissionTest(int n, int repetitions, int expected)
        {
            // Arrange
            var employeeRepo = new EmployeeRepo(null); 

            // Act
            var result = employeeRepo.CalculateReducedScoreForAbscenceWithPermission(n, repetitions);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
