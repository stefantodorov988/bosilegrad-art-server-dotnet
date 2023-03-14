using bosilegrad_art_server_dotnet.Application.Common.Interfaces;

namespace bosilegrad_art_server_dotnet.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
