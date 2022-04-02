using PoniLCU;
using static PoniLCU.LeagueClient;
using YESuo.Models;
using Newtonsoft.Json;
bool firsttime = true;
string version = "1.0";
Console.Title = "YESuo v"+version;
var client = new LeagueClient(credentials.lockfile);
if (client.IsConnected==true)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor= ConsoleColor.Black;
    Console.WriteLine("All things are ready");
    Console.WriteLine("Let's Nom-Nom-Nom them");
    Console.ResetColor();
}
else if (client.IsConnected == false)
{
    Console.BackgroundColor = ConsoleColor.DarkRed;    
    Console.WriteLine("League of legends is closed. Who the F do you want to feed now ?!");
    Console.ResetColor();
}
client.Subscribe("/lol-champ-select/v1/session", ChampSelectSessionAsync);
t().GetAwaiter().GetResult();

async void ChampSelectSessionAsync(OnWebsocketEventArgs obj)
{
    if (obj.Type.ToUpper() != "UPDATE")
    {
        return;
    }

    var session = JsonConvert.DeserializeObject<Root>(await client.Request(requestMethod.GET,"lol-champ-select/v1/session"));
    foreach (var action in session.actions[0])
    {
        if (action.isAllyAction && action.completed == false && action.type == "pick" && action.isInProgress == true && action.championId != 157)
        {
            var body = new
            {
                actorCellId = session.localPlayerCellId,
                championId = 157,
                isAllyAction = true,

            };
            firsttime = true;
            Console.WriteLine("It's Your turn!!");
            Console.WriteLine("press any key to pick yasuo in despite of YasuNO");
            Console.ReadKey();
            await client.Request(requestMethod.PATCH, $"/lol-champ-select/v1/session/actions/{action.id}", Newtonsoft.Json.JsonConvert.SerializeObject(body));
            await client.Request(requestMethod.POST, $"/lol-champ-select/v1/session/actions/{action.id}/complete", Newtonsoft.Json.JsonConvert.SerializeObject(body));

        }
        if (action.isAllyAction && action.completed == true && action.type == "pick" && action.isInProgress == false && action.championId == 157 && firsttime)
        {
            Console.WriteLine("GO FEED NOW");
            firsttime = false;   
        }
    }
    
}

static async Task t()
{
    while (true)
    {
        await Task.Delay(1000);
    }

}