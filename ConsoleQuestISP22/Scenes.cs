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
        int _sceneNuber = 0;
        string _sceneIntro = "";
        public Scenes() { }

        /// <summary>
        /// конструктор сцены.
        /// </summary>
        /// <param name="number">номер сцены.</param>
        /// <param name="name">описание сцены.</param>
        public Scenes(int number, string name = "", string intro = "") 
        {
            _sceneName = name;
            _sceneNuber = number;  
            _sceneIntro = intro;   
        }
        
        public void AddSome (int i, params string[] parameters) 
        { 
            foreach (string parameter in parameters) 
            {
                Console.WriteLine(parameter);
            }
        }
        

        /// <summary>
        /// Задаёт имя сцены.
        /// </summary>
        public string SceneName { 
            get { return _sceneName; } 
            set { _sceneName = value; }
        }

        public int SceneNumber
        {
            get { return _sceneNuber; }
            set { _sceneNuber = value; }
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
