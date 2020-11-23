using System;

namespace Giraffe.API.Abstractions
{
    public interface IDateTimeProvider
    {
        DateTime CurrentDateTime();
    }
}
