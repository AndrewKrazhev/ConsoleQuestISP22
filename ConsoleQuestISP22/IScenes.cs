using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuestISP22
{
    internal interface IScenes
    {
        
        public int Num { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
        public void ShowScene();

    }
}
