using System;
using Discord.WebSocket;
using System.Threading.Tasks;
using Discord;

namespace RedDolphin
{
    class Program
    {
        DiscordSocketClient _client;
        CommandHandler _handler;
        static void Main(string[] args)
            => new Program().StartAsync().GetAwaiter().GetResult();

        

        public async Task StartAsync()
        {
            if (Config.bot.token == "" || Config.bot.token == null) return;
            _client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = Discord.LogSeverity.Verbose

            });
            _client.Log += Log;
            await _client.LoginAsync(TokenType.Bot, Config.bot.token);
            await _client.StartAsync();
            _handler = new CommandHandler();
            await _handler.InitializeAsync(_client);
            await Task.Delay(-1);

        }

        private async Task Log(Discord.LogMessage msg)
        {
            Console.WriteLine(msg.Message);
        }
    }
}
