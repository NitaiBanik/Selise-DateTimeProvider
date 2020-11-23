using Giraffe.API.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;

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
            return _datetimeProvider.CurrentDateTime();
        }
    }
}