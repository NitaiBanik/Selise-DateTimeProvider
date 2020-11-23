using Giraffe.API;
using Giraffe.API.Abstractions;
using Moq;
using System;
using Xunit;

namespace GiraffeTest.Test
{
    public class DateTimeProviderTest
    {

        [Fact]
        public void CurrentDateTimeTest()
        {
            var datetimeProviderMock = new Mock<IDateTimeProvider>();
            datetimeProviderMock.Setup(d => d.CurrentDateTime())
                .Returns(new DateTime(2020, 11, 23));

            var current = new CurrentDateTimeProvider(datetimeProviderMock.Object);

            current.CurrentTime().ToString().Length.Equals(4);
        }

    }
}
