using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace RedDolphin.Module
{
    public class Misc : ModuleBase<SocketCommandContext>
    {
        [Command("dol")]
        public async Task Echo()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Dolphin Message");
            //embed.WithDescription(msg); // if return the same message
            embed.WithColor(new Color(64, 161, 255)); // #40A1FF
            embed.WithImageUrl("https://i.imgur.com/SFvJmge.jpg"); // Dolphin pic

            await Context.Channel.SendMessageAsync("",false,embed.Build());
        }

        /*
        [Command("")]

        public async Task Example([Remainder]string msg) //if taking multiple parameters
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Dolphin Message");
            //embed.WithDescription(msg); // if return the same message
            embed.WithColor(new Color(64, 161, 255)); // #40A1FF
            embed.WithImageUrl("https://i.imgur.com/SFvJmge.jpg"); // Dolphin pic

            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }

        */
    }
}
