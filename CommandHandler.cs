using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;
using System.Reflection;

namespace RedDolphin
{
    class CommandHandler
    {
        DiscordSocketClient _client;
        CommandService _service;
        
        public async Task InitializeAsync(DiscordSocketClient client)
        {
            _client = client;
            _service = new CommandService();
            await _service.AddModulesAsync(assembly: Assembly.GetEntryAssembly(),services: null);
            _client.MessageReceived += HandleCommandAsync;
            await _client.SetGameAsync("I am a Dolphin");
        }

        private async Task HandleCommandAsync(SocketMessage s)
        {
            var msg = s as SocketUserMessage;
            if (msg == null) 
            { 
                return;
            }
            var context = new SocketCommandContext(_client, msg);
            int argpos = 0;
            if (msg.HasStringPrefix(Config.bot.cmdPrefix, ref argpos) || msg.HasMentionPrefix(_client.CurrentUser, ref argpos))
            {
                var result = await _service.ExecuteAsync(context, argpos,null);
                if(!result.IsSuccess && result.Error != CommandError.UnknownCommand)
                {
                    Console.WriteLine(result.ErrorReason);
                }
            }
        }
    }
}
