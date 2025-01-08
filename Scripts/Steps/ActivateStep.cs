using UnityEngine;

namespace Tutorial.Steps
{
    public class ActivateStep : TutorialStep
    {
        [SerializeField] private GameObject[] objectsToActivate = new GameObject[1];
        [SerializeField] private bool activeState = true;

        public override void StartStep()
        {
            foreach (var objectToActivate in objectsToActivate)
            {
                if (objectToActivate == null) continue;
                objectToActivate.SetActive(activeState);
            }

            CompleteStep();
        }
    }
}
