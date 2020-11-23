using Giraffe.API.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giraffe.API
{
    public class CurrentDateTimeProvider
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public CurrentDateTimeProvider(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider ?? throw new ArgumentNullException(nameof(dateTimeProvider));
        }

        public DateTime CurrentTime()
        {
            return _dateTimeProvider.CurrentDateTime();
        }
    }
}
