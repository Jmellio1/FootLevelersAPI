/*
 * 
 * 
 * 
 * Since we not doing anything with the API I’m using a minimal API with default values. 
 * No need to make thing harder than necessary 
 * Can grow in scope/ scale easily  
 *
 */
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/ping", (string message) =>
{
    
    return new ApiResponse() { Message = message };
       
      
});
app.Run();
public class ApiResponse
{
    public string Response { get; set; } = "Pong";
    public string Message { get; set; } = "return the message from the api endpoint";
}
