using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMTask1
{
    class TaskActivator : IRunnable
    {
        public object Run()
        {
            return new Messenger();
        }
    }
}
