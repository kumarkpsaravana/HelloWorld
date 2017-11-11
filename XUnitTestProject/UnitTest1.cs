using System;
using Xunit;

namespace XUnitTestProject
{

    public class UnitTest1
    {

        public void TestMethod1()
        {

        }

        [Fact]
        public void TestMethod2()
        {

        }

        [Fact]
        public void TestMethod3()
        {
        }

        [Obsolete]
        public void TestMethod4()
        {
            Assert.Equal("", "asd");
        }

        [Theory]
        [InlineData(true, false)]
        [InlineData(true, true)]
        public void TestBugDodges(bool didDodge, bool shouldBeDead)
        {
            Assert.Equal(true, didDodge);
        }

        public static TheoryData<bool> DataForTest1 = new TheoryData<bool> {
    { true }, { false },{true},{false } };

        [Theory(DisplayName = "Test 1"), MemberData(nameof(DataForTest1))]
        public void Test1(bool valB)
        {
            Assert.Equal(true, valB);
        }

        public static TheoryData<string> DataForTest2 = new TheoryData<string> {
    { "g2" }, { "g2T" },{"cg"},{"common" } };

        [Theory(DisplayName = "Test 2 "+ (nameof(DataForTest2))), MemberData(nameof(DataForTest2))]
        public void Test2(string valB)
        {
            Assert.Equal("cg", valB);
        }


    }
}
