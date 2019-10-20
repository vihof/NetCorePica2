using Core;
using Xunit;

namespace CoreTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Class1 t = new Class1();

            int result = t.Suma(2, 3);
            Assert.Equal(5, result);
        }
    }
}