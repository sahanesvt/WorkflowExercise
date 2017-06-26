using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowExercise
{
    class Walking : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Walking");
        }
    }
}
