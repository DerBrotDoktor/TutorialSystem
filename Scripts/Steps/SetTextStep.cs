
using TMPro;
using UnityEngine;

namespace Tutorial.Steps
{
    public class SetTextTask : TutorialStep
    {
        [SerializeField] private TMP_Text textObject;
        [SerializeField, TextArea] private string text;

        public override void StartStep()
        {
            textObject.text = text;
            CompleteStep();
        }
    }
}
