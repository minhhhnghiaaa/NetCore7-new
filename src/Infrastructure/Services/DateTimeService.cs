using NetCore7.Application.Common.Interfaces;

namespace NetCore7.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
