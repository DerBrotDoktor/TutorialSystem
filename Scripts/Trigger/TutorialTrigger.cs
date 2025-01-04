using UnityEngine;
using UnityEngine.Serialization;

namespace Tutorial.Trigger
{
    /// <summary>
    /// Base class for all tutorial triggers
    /// </summary>
    public class TutorialTrigger : MonoBehaviour
    {
        [SerializeField] private Tutorial targetTutorial;

        protected void TriggerTutorial()
        {
            TutorialManager.Instance.StartTutorial(targetTutorial);
        }
    }
}
