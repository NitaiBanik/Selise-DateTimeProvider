using Giraffe.API.Abstractions;
using System;

namespace Giraffe.API
{
    public class DateTimeProvider
        : IDateTimeProvider
    {
        public DateTime DateTimeNow {get; private set; }
        public DateTime CurrentDateTime()
        {
            return DateTimeNow = DateTime.UtcNow;
        }
    }
}
