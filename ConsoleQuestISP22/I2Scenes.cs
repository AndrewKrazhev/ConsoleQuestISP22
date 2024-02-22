using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuestISP22
{
    internal class I2Scenes : IScenes
    {
        int _num = 0;
        string _desc = String.Empty;
        string _name = String.Empty;
        
        public I2Scenes() { }

        public I2Scenes(int num, string description, string name)
        {
            Num = num;
            Name = name;            
            Description = description;            
        }

        public int Num { get { return _num; } set { _num = value; } }
        public string Description { get { return _desc; } set { _desc = value; } }
        public string Name { get { return _name;} set { _name = value; } }


        public void ShowScene() 
        {
            Console.WriteLine($"Сцена #{_num} имя: {_name}, описание: {_desc} ");
        }

    }
}
