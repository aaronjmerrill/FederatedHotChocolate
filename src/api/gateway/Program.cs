WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("Fusion");

builder.Services
    .AddFusionGatewayServer()
    .ConfigureFromFile("./gateway.fgp");

WebApplication app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);