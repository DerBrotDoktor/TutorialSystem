using System.Linq;
using UnityEngine;

namespace Tutorial
{
    public class TutorialManager : MonoBehaviour
    {
        public static TutorialManager Instance { get; private set; }

        [SerializeField] private Tutorial[] tutorials;

        private Tutorial currentTutorial;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Debug.LogError("Multiple instances of TutorialManager found in scene");
                Destroy(gameObject);
            }
        }

        public void StartTutorial(Tutorial tutorial)
        {
            if (currentTutorial != null) return;
            if (!tutorials.Contains(tutorial)) return;
            if (tutorial.IsComplete) return;

            currentTutorial = tutorial;
            tutorial.StartTutorial();
        }

        public void CompleteTutorial(Tutorial tutorial)
        {
            if(tutorial == null) return;
            if(currentTutorial == null) return;
            if(tutorial != currentTutorial) return;

            currentTutorial = null;
        }
    }
}

