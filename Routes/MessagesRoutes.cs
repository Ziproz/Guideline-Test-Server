using GuidelineTest.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace GuidelineTest.Routes
{
    public static class MessagesRoutes
    {
        public static void MapMessages(this IEndpointRouteBuilder app)
        {
            var organizationGroup = app.MapGroup("api/messages/");
            organizationGroup.MapPost("SendMessage", async (IMessageService messageService, [FromBody] MessageRequest request) =>
            {
                messageService.SendMessage(request.workerId,request.msg);

                //log- Send Success
                return Results.Ok();
            })
            .AllowAnonymous();
        }
    }
}
