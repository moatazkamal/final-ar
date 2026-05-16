using UnityEngine;
using UnityEngine.UI;

public class DoorAnimationButton : MonoBehaviour
{
    public Button button;
    public Animator doorAnimator;
    public string boolName = "Open";

    private bool isOpen = false;

    void Start()
    {
        button.onClick.AddListener(ToggleDoor);
    }

    void ToggleDoor()
    {
        isOpen = !isOpen;
        doorAnimator.SetBool(boolName, isOpen);
    }
}