using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuestISP22
{
    internal class Scenes
    {
        string _sceneName = "";
        /// <summary>
        /// Задаёт имя сцены.
        /// </summary>
        public string SceneName { 
            get { return _sceneName; } 
            set { _sceneName = value; }
        }

        /// <summary>
        /// Показывает сцену.
        /// </summary>
        /// <returns><b>истина</b> в случае успеха.</returns>
        public bool Show()
        {
            Console.WriteLine(_sceneName);
            return true;
        }

    }
}
