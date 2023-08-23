using CAapp.Application.Common.Interfaces;

namespace CAapp.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
