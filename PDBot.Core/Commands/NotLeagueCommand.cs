using PDBot.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDBot.Core.GameObservers;
using PDBot.Core.Interfaces;
using PDBot.Interfaces;

namespace PDBot.Core.Commands
{
    class NotLeagueCommand : ICommand
    {
        public string[] Handle { get; } = new string[] { "!notleague" };

        public bool AcceptsGameChat => true;

        public bool AcceptsPM => false;

        public Task<string> RunAsync(string player, IMatch match, string[] args)
        {
            if (match?.Observers?.SingleOrDefault(o => o is GameObservers.LeagueObserver) is GameObservers.LeagueObserver LeagueObserver && LeagueObserver.HostRun != null && LeagueObserver.LeagueRunOpp != null)
            {
                LeagueObserver.HostRun = null;
                match.Log("[League] Invalid Match");
                return Task.FromResult($"[sD] Ok, I won't treat this as a league match.\nIf you change your mind, please @[Report] manually.");
            }
            else
            {
                return Task.FromResult($"[sD] This isn't a @[League] match.");
            }
        }
    }
}
