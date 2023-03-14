using bosilegrad_art_server_dotnet.Application.Common.Exceptions;
using bosilegrad_art_server_dotnet.Application.TodoLists.Commands.CreateTodoList;
using bosilegrad_art_server_dotnet.Application.TodoLists.Commands.DeleteTodoList;
using bosilegrad_art_server_dotnet.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace bosilegrad_art_server_dotnet.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
