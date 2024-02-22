using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuestISP22
{
    internal class FightScenes : Scenes
    {
        int _playerHP = 100;

        public int PlayerHP { get { return _playerHP;} }
    }
}
