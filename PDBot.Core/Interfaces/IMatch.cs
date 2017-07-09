﻿using PDBot.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBot.Core.Interfaces
{
    public interface IMatch
    {
        string[] Players { get; }
        string Comments { get; }
        WinnerDictionary Winners { get; }
        IGameObserver[] Observers { get; }
        Room GameRoom { get; }

        void SendChat(string message);
    }
}
