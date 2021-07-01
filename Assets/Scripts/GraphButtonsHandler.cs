using UnityEngine;
using UnityEngine.UI;

public class GraphButtonsHandler : MonoBehaviour
{
    private GraphManager graphManager;

    [SerializeField] private Button leftButton, rightButton;

    private void Start()
    {
        graphManager = FindObjectOfType<GraphManager>();
        leftButton.onClick.AddListener(LeftButtonClick);
        rightButton.onClick.AddListener(RightButtonClick);
    }

    private void RightButtonClick()
    {
        graphManager.NextMathematicalFunction();
        Debug.Log("Right button clicked");
    }

    private void LeftButtonClick()
    {
        graphManager.PreviousMathematicalFunction();
        Debug.Log("Left button clicked");
    }
}
