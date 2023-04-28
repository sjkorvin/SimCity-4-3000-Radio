using System;
using ICities;
using UnityEngine;
using System.Collections;
using System.IO;

namespace MusicPack_SimCity_3000___4
{
    public class CSLMusicPack : IUserMod
    {
        public string Name
        {
            get
            {
                return "SimCity 3000 & 4";
            }
        }

        public string Description
        {
            get
            {
                return "SimCity 3000 & 4 Jams!";
            }
        }
    }
}