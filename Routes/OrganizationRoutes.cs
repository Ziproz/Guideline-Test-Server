namespace GuidelineTest.Routes
{
    public static class OrganizationRoutes
    {
        public static void MapOrganization(this IEndpointRouteBuilder app)
        {
            var organizationGroup = app.MapGroup("api/organization/");
            organizationGroup.MapGet("getWorkerList", async (IOrganizationService organizationService) =>
            {
                var workerList = organizationService.GetWorkerList();

                return Results.Ok(workerList);
            })
            .AllowAnonymous();
        }
    }
}
