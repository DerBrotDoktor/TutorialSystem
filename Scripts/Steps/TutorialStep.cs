using System;
using UnityEngine;

namespace Tutorial.Steps
{
    /// <summary>
    /// Base class for all tutorial steps
    /// </summary>
    public class TutorialStep : MonoBehaviour
    {
        public virtual void StartStep()
        {

        }

        public virtual void Update()
        {

        }

        protected virtual void CompleteStep()
        {
            NextStep();
        }

        protected void NextStep()
        {
            if(transform.parent.TryGetComponent<Tutorial>(out Tutorial tutorial))
            {
                tutorial.NextStep();
            }
            else
            {
                Debug.LogError("Could not find Tutorial component on " + transform.parent.name);
            }
        }
    }
}
