using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Containers__part_1_
{
    internal class Model : IModel
    {
        public event EventHandler<EventArgs> IsSafeOpened;
        public bool IsCodeCorrect(string code)
        {
            return code == "8215";
        }
        public void OnSafeOpened()
        {
            IsSafeOpened?.Invoke(this, EventArgs.Empty);
        }
    }
}