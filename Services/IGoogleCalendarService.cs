using Google.Apis.Calendar.v3.Data;

namespace DailyDays.Services;

public interface IGoogleCalendarService
{
    Task<Event> CreateEvent(Event request, CancellationToken cancellationToken);
}