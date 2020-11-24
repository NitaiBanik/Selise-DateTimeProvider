using System;

namespace Giraffe.API.Abstractions
{
    public interface IDateTimeProvider
    {
        public DateTime Now { get { return DateTime.Now; } }
    }
}
