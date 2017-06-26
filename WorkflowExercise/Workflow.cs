using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowExercise
{
    class Workflow
    {
        private List<IActivity> _activities = new List<IActivity>();
        public void Run()
        {
            foreach (IActivity activity in _activities)
            {
                activity.Execute();
            }
        }

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
