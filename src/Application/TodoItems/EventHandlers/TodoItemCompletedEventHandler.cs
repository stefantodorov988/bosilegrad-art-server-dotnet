using bosilegrad_art_server_dotnet.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace bosilegrad_art_server_dotnet.Application.TodoItems.EventHandlers;

public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("bosilegrad_art_server_dotnet Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
