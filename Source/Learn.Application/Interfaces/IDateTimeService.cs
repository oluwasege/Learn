using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
