using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Containers__part_1_
{
    internal interface IView
    { 
        event EventHandler<string> IsCodeEntered;
        void DisplayMessage(string message);
    }
}