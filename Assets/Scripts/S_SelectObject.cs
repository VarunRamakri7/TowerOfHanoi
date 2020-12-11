using UnityEngine;
using UnityEngine.UI;

public class S_SelectObject : MonoBehaviour
{
    public GameObject highlight; // Image attached to this object
    public GameObject highlightController;

    // This objects information
    private bool isDisc;
    private int objNum;

    // Get the Image component on Start
    private void Start()
    {
        // Get the object info at start
        isDisc = this.GetComponent<S_ObjectType>().isDisc;
        objNum = this.GetComponent<S_ObjectType>().objectNum;
    }

    // Check if user interacts with this object
    private void OnMouseOver()
    {
        //Debug.Log("Mouse Over...");

        // Check if user clicks on object
        if (Input.GetMouseButtonDown(0))
        {
            // Highlight object if user clicks on it
            /*highlight.SetActive(true);*/
            highlightController.GetComponent<S_HighlightController>().HighlightObject(isDisc, objNum);
            this.GetComponent<S_ObjectType>().isSelected = true; // Update object selection
            Debug.Log("Highlighted...");
        }
    }

    // Move Disc to the another tower
    /*private void MoveDisc()
    {

    }*/
}
