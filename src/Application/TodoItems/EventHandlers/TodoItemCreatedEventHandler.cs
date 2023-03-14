using bosilegrad_art_server_dotnet.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace bosilegrad_art_server_dotnet.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("bosilegrad_art_server_dotnet Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
