using Giraffe.API;
using Giraffe.API.Abstractions;
using Moq;
using System;
using FluentAssertions;
using Xunit;

namespace GiraffeTest.Test
{
    public class DateTimeProviderTest
    {

        [Fact]
        public void CurrentDateTimeTest()
        {
            var datetimeProviderMock = new Mock<IDateTimeProvider>();

            datetimeProviderMock.Setup(d => d.Now)
                .Returns(new DateTime(2020, 01, 01, 10, 00, 00));

            var currentDateTime = new CurrentDateTimeProvider(datetimeProviderMock.Object);

            currentDateTime.CurrentTime().Hour.Should().Be(10);

        }
    }
}
