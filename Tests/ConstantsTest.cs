using System;
using CrashCourse2020ExercisesDayThree.Src;
using Xunit;

namespace CrashCourse2020ExercisesDayThree.Tests
{
    public class ConstantsTest
    {
        [Fact]
        public void ConstantStringEvenTest()
        {
            Assert.Equal("FirstName Must Be 2 Or More Characters", Constants.FirstNameException);
        }
    }
}
