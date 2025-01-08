using UnityEngine;

namespace Tutorial.Steps
{
    public class SetTransformStep : TutorialStep
    {
        [SerializeField] private Vector3 newPosition;
        [SerializeField] private Vector3 newRotation;
        [SerializeField] private Vector3 newScale;
        [SerializeField] private Transform targetTransform;

        public override void StartStep()
        {
            targetTransform.position = newPosition;
            targetTransform.rotation = Quaternion.Euler(newRotation);
            targetTransform.localScale = newScale;
            CompleteStep();
        }
    }
}
