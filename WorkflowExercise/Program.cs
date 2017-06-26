using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            var sleeping = new Sleeping();
            var walking = new Walking();
            workflow.AddActivity(sleeping);
            workflow.AddActivity(walking);

            workflow.Run();
            Console.ReadLine();
        }
    }
}
