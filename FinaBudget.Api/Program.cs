using FinaBudget.Api;
using FinaBudget.Api.Common.Api;
using FinaBudget.Api.Endpoints;

    static int SimpleAdding(int num)
    {
        var sum = 0;
        for (int i = 1; i < num; i++){
            sum += i;
        }
        return num;
    }

Console.WriteLine(SimpleAdding(12));

Console.ReadKey();
//var builder = WebApplication.CreateBuilder(args);
//builder.AddConfiguration();
//builder.AddDataContexts();
//builder.AddCrossOrigin();
//builder.AddDocumentation();
//builder.AddServices();

//var app = builder.Build();
//if (app.Environment.IsDevelopment())
//    app.ConfigureDevEnvironment();

//app.UseCors(ApiConfiguration.CorsPolicyName);
//app.MapEndpoints();

//app.Run();