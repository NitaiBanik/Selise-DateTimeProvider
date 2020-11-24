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
        private const int desiredHour = 9;
        private const int marginHour = 2;
        private const int desiredDate = 2;
        private const int marginDate = 1;

        [Fact]
        public void CurrentDateTimeTest()
        {
            var datetimeProviderMock = new Mock<IDateTimeProvider>();

            datetimeProviderMock.Setup(d => d.Now)
                .Returns(new DateTime(2020, 01, 01, 10, 00, 00));

            var currentDateTime = new CurrentDateTimeProvider(datetimeProviderMock.Object);

            currentDateTime.CurrentTime().Hour.Should().BeCloseTo(desiredHour, marginHour, "Margin Not close to desired hour");
            currentDateTime.CurrentTime().Day.Should().BeCloseTo(desiredDate, marginDate, "Margin Not close to desired date");

        }
    }
}
