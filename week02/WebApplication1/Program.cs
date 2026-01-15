using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// create a TODO list endpoint
var todos = new List<Todo>();

app.MapGet("/todos", () => todos); // return the list of todos
app.MapGet("/todos/{id}", Results<Ok<Todo>, NotFound> (int id) => // return todo by id
{
    var targetTodo = todos.SingleOrDefault(t => id == t.Id);
    return targetTodo is null ? TypedResults.Ok(targetTodo) : TypedResults.NotFound();
});

app.MapPost("/todos", (Todo task) =>
{
    todos.Add(task);
    return TypedResults.Created("/todos/{id}", task);
});

// delete a TODO item by id
app.MapDelete("/todos/{id}", Results<NoContent, NotFound> (int id) =>
{
    var targetTodo = todos.SingleOrDefault(t => id == t.Id);
    if (targetTodo is null)
    {
        return TypedResults.NotFound();
    }

    todos.Remove(targetTodo);
    return TypedResults.NoContent();
});


app.Run();

internal class Todo
{
    public int Id { get; internal set; }
}