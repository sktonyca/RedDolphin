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
        /*
            [Command("")]

            public async Task Example([Remainder]string msg) //if taking multiple parameters
            {
                var embed = new EmbedBuilder();
                embed.WithTitle("Dolphin Message"); // title of the message
                //embed.WithDescription(msg); // text for the message
                embed.WithColor(new Color(64, 161, 255)); // #40A1FF set the color of the message
                embed.WithImageUrl("https://i.imgur.com/SFvJmge.jpg"); // Dolphin pic

                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
        */

        [Command("dol")] // Return a picture of a Dolphin
        public async Task Dol()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Dolphin Message");
            embed.WithDescription("Here's a Dolphin");
            embed.WithColor(new Color(64, 161, 255)); // #40A1FF
            embed.WithImageUrl("https://i.imgur.com/SFvJmge.jpg"); // Dolphin pic

            await Context.Channel.SendMessageAsync("",false,embed.Build());
        }
        [Command("help")] // Return list of commands that can be used

        public async Task Help()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("List of available Commands");
            embed.WithDescription("$help: shows available commands \n$time parameter: shows time in a certain time zone" +
                "\ncurrently supported time zones: UTC, Local, KST");
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }

        [Command("time")]

        public async Task Example([Remainder]string msg) //if taking multiple parameters
        {
            if (msg == "utc") // Return UTC
            { 
                var embed = new EmbedBuilder();
                embed.WithTitle(TimeZoneInfo.Utc.ToString()); // title of the message
                embed.WithDescription((DateTime.UtcNow).ToString()); // text for the message
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }

            if (msg == "local") // Return local time
            {
                var embed = new EmbedBuilder();
                embed.WithTitle(TimeZoneInfo.Local.StandardName.ToString()); // title of the message
                embed.WithDescription((DateTime.Now).ToString()); // text for the message
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }

            if (msg == "kst") // Return Korea Standard Time
            {
                var embed = new EmbedBuilder();
                TimeZoneInfo kst = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");
                DateTime kstTime = TimeZoneInfo.ConvertTime(DateTime.Now, kst);
                embed.WithTitle(kst.StandardName); // title of the message
                embed.WithDescription(kstTime.ToString()); // text for the message
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
        }
    
    }
}
