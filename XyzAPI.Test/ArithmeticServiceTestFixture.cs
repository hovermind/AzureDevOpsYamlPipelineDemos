using Moq;
using System;
using XyzAPI.Repositories;
using XyzAPI.Services;

namespace XyzAPI.Test
{
    public class ArithmeticServiceTestFixture : IDisposable
    {
        public ArithmeticService Sut { get; private set; }

        public ArithmeticServiceTestFixture()
        {
            var mockedRepository = new Mock<IArithmeticRepository>();

            Sut = new ArithmeticService(mockedRepository.Object);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
