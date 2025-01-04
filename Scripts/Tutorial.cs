using System;
using Tutorial.Steps;
using UnityEngine;

namespace Tutorial
{
    public class Tutorial : MonoBehaviour
    {
        [SerializeField,
        Tooltip("The tutorial to run next.\nLeave blank to not run a next one.")]
        private Tutorial nextTutorial;

        private TutorialStep[] steps;
        private int currentStepIndex = 0;

        private bool isActive = false;
        public bool IsComplete { get; private set; } = false;

        private void Awake()
        {
            steps = GetComponentsInChildren<TutorialStep>(includeInactive: true);
            foreach (var step in steps)
            {
                step.gameObject.SetActive(false);
            }
        }

        public void StartTutorial()
        {
            if(isActive || IsComplete) return;

            currentStepIndex = -1;
            isActive = true;
            NextStep();
        }

        public void NextStep()
        {
            if (currentStepIndex >= 0)
            {
                steps[currentStepIndex].gameObject.SetActive(false);
            }

            currentStepIndex++;

            if (currentStepIndex >= steps.Length)
            {
                CompleteTutorial();
            }
            else
            {
                var step = steps[currentStepIndex];

                step.gameObject.SetActive(true);
                step.StartStep();
            }
        }

        private void CompleteTutorial()
        {
            isActive = false;
            IsComplete = true;

            TutorialManager.Instance.CompleteTutorial(this);
            if (nextTutorial != null)
            {
                TutorialManager.Instance.StartTutorial(nextTutorial);
            }
        }
    }
}
