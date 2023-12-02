using JasonTaylorCleanArq.Infrastructure.Identity;

namespace JasonTaylorCleanArq.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapIdentityApi<ApplicationUser>();
    }
}
