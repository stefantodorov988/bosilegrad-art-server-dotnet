using bosilegrad_art_server_dotnet.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace bosilegrad_art_server_dotnet.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
