using UnityEngine;
using Unity.VisualScripting;

public class DialogueAdvancer : MonoBehaviour
{
    [SerializeField] private DialogueNode nextLine;
    [SerializeField] private DialogueNode otherLine;

    // Button hooks up to this method
    private void Start()
    {
        EventBus.Trigger(EventNames.NewDialogueEvent, otherLine);
    }

    public void ChooseDialogue ()
    {
        EventBus.Trigger(EventNames.NewDialogueEvent, nextLine);
    }

    public void PrintHello ()
    {
        Debug.Log("hello!");
    }
}
