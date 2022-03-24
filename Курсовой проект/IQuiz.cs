using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект
{
    interface IQuiz
    {
        string Filepart_geor { get; }
         string Filepart_geor1 { get; }       
         int Count_ { get; set; } 
        string Word { get; set; }

        void one();
    }
}
