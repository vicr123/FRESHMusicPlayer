﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRESHMusicPlayer.Handlers.Plugins
{
    public interface IPlugin
    {
        string Name { get; set; }
        string Description { get; set; }
        string Author { get; set; }
        MainWindow Window { get; set; }
        Player Player { get; set; }
        void Load();
        void Unload();
    }
}