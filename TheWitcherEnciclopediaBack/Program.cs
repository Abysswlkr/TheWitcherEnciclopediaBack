using Microsoft.EntityFrameworkCore;
using TheWitcherEnciclopediaBack.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<TheWitcherEncyclopediaContext>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(policy =>
    policy.WithOrigins("http://localhost:4200") 
          .AllowAnyHeader()
          .AllowAnyMethod()
          .AllowCredentials());

app.MapControllers();

//Con la inyección de dependencias (Metodo GET)
app.MapGet("/personajes", (TheWitcherEncyclopediaContext db) => db.Personajes.ToList());


app.MapGet("/historias/{id}", async (TheWitcherEncyclopediaContext db, int id) => {
    var historia = await db.HistoriaTramas.FirstOrDefaultAsync(h => h.JuegoId == id);

    if (historia != null)
    {
        return Results.Ok(historia);
    }
    else
    {
        return Results.NotFound($"No se encontró ninguna historia con el id {id}");
    }
});

//Con la inyección de dependencias (Metodo GET)
app.MapGet("/localizaciones", (TheWitcherEncyclopediaContext db) => db.Localizaciones.ToList());

//Con la inyección de dependencias (Metodo GET)
app.MapGet("/bestiario", (TheWitcherEncyclopediaContext db) => db.Bestiarios.ToList());

//Con la inyección de dependencias (Metodo GET)
app.MapGet("/bestiario/{id}", async (TheWitcherEncyclopediaContext db, int id) => {
    var bestiario = await db.Bestiarios.FirstOrDefaultAsync(b => b.MonstruoId == id);

    if (bestiario != null)
    {
        return Results.Ok(bestiario);
    }
    else
    {
        return Results.NotFound($"No se encontró ninguna historia con el id {id}");
    }
});

//Con la inyección de dependencias (Metodo GET)
app.MapGet("/sistema/{id}", async (TheWitcherEncyclopediaContext db, int id) => {

    var sistema = await db.SistemaJuegos.FirstOrDefaultAsync(s => s.MecanicaId == id);

    if (sistema != null)
    {
        return Results.Ok(sistema);
    }
    else
    {
        return Results.NotFound($"No se encontró ninguna historia con el id {id}");
    }

});

//Con la inyección de dependencias (Metodo GET)
app.MapGet("/arteDiseno", (TheWitcherEncyclopediaContext db) => db.ArteDisenos.ToList());

//Con la inyección de dependencias (Metodo GET)
app.MapGet("/arteDiseno/{id}", async (TheWitcherEncyclopediaContext db, int id) => {

    var arteDiseno = await db.ArteDisenos.FirstOrDefaultAsync(a => a.ArteId == id);

    if (arteDiseno != null)
    {
        return Results.Ok(arteDiseno);
    }
    else
    {
        return Results.NotFound($"No se encontró ninguna historia con el id {id}");
    }

});

//Con la inyección de dependencias (Metodo GET)
app.MapGet("/curiosidades", (TheWitcherEncyclopediaContext db) => db.Curiosidades.ToList());

app.Run();
