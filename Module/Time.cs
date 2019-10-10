using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace RedDolphin.Module
{
    public class Time : ModuleBase<SocketCommandContext>
    {
        [Command("time")]

        public async Task Example([Remainder]string msg)
        {
            if (msg == "utc") // Return UTC
            {
                var embed = new EmbedBuilder();
                embed.WithTitle("Time Zone: " + TimeZoneInfo.Utc); // title of the message
                embed.WithDescription((DateTime.UtcNow).ToString()); // text for the message
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }

            if (msg == "local") // Return local time
            {
                var embed = new EmbedBuilder();
                embed.WithTitle("Time Zone: " + TimeZoneInfo.Local); // title of the message
                embed.WithDescription((DateTime.Now).ToString()); // text for the message
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
        }

    }
}