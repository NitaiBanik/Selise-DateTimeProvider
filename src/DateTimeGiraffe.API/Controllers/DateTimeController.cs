using Giraffe.API.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using Moq;
using Giraffe.API;

namespace CurrentDatetime.API.Controllers
{
    [ApiController]
    public class DatetimeController : ControllerBase
    {
        private readonly IDateTimeProvider _datetimeProvider;

        public DatetimeController(IDateTimeProvider datetimeProvider)
        {
            _datetimeProvider = datetimeProvider ?? throw new ArgumentNullException(nameof(datetimeProvider));
        }

        [HttpGet]
        [Route("api/v1/datetimeutcnow")]
        public DateTime Now()
        {
            var datetimeProviderMock = new Mock<IDateTimeProvider>();

            datetimeProviderMock.Setup(d => d.Now)
                .Returns(new DateTime(2020, 01, 01, 10, 00, 00));
            var currentDateTime = new CurrentDateTimeProvider(datetimeProviderMock.Object);
            return currentDateTime.CurrentTime();
        }
    }
}