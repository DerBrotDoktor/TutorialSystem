using UnityEngine;

namespace Tutorial.Steps
{
    public class ActivateStep : TutorialStep
    {
        [SerializeField] private GameObject objectToActivate;
        [SerializeField] private bool activeState = true;

        public override void StartStep()
        {
            objectToActivate.SetActive(activeState);
            CompleteStep();
        }
    }
}
