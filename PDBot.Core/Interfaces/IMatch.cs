using PDBot.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBot.Core.Interfaces
{
    public interface IMatch
    {
        int MatchID { get; }
        string[] Players { get; }
        string Comments { get; }
        bool Completed { get; }
        WinnerDictionary Winners { get; }
        IGameObserver[] Observers { get; }
        Room GameRoom { get; }
        MagicFormat Format { get; }
        int MinutesPerPlayer { get; }

        void SendChat(string message);
        string Log(string message);

        List<string> NamedTokens { get; }
    }
}
