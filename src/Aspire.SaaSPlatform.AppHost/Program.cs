var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Aspire_SaaSPlatform_ApiService>("apiservice");

builder.AddProject<Projects.Aspire_SaaSPlatform_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
