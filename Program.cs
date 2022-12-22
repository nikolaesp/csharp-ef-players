// See https://aka.ms/new-console-template for more information
using EntityFrameworkPlayers;

Console.WriteLine("Hello, World!");

using (PlayerContext db = new PlayerContext())
{
    Random rand = new Random();
    double points = rand.Next(1, 10);
    Random rnd = new Random();
    int played = rnd.Next(1, 100); 
    int won = rnd.Next(1, played);
    Player pandev = new Player() { nome="Goran" ,cognome="Pandev",punteggio=points,numero_giocate=played,numero_vinte=won};
    db.Add(pandev);
    db.SaveChanges();
    Console.WriteLine("Goce added !");
}