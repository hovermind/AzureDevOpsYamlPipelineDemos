using AutoFixture.Xunit2;
using Xunit;

namespace XyzAPI.Test
{
    public class ArithmeticServiceTest : IClassFixture<ArithmeticServiceTestFixture>
    {
        private readonly ArithmeticServiceTestFixture _classFixture;
        public ArithmeticServiceTest(ArithmeticServiceTestFixture classFixture)
        {
            _classFixture = classFixture;
        }

        [Theory]
        [InlineAutoData(2, 2, 4)]
        [InlineAutoData(2, 1, 3)]
        [InlineAutoData(5, 7, 12)]
        public void Addition_Test(int x, int y, int expectedResult)
        {
            var result = _classFixture.Sut.Add(x, y);

            Assert.Equal(expectedResult, result);
        }
    }
}
