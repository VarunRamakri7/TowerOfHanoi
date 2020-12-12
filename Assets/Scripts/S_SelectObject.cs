using UnityEngine;
using UnityEngine.UI;

public class S_SelectObject : MonoBehaviour
{
    public GameObject highlight; // Image attached to this object

    public GameObject highlightController; // Highlight controller in game
    public GameObject stackController; // View Tower's stack contents

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
        // Check if user clicks on object
        if (Input.GetMouseButtonDown(0))
        {
            // Allow only if disc and tower are not selected
            if (!highlightController.GetComponent<S_HighlightController>().twoSelected)
            {
                // Highlight object if user clicks on it
                highlightController.GetComponent<S_HighlightController>().HighlightObject(isDisc, objNum, true);
                this.GetComponent<S_ObjectType>().isSelected = true; // Update object selection
                //Debug.Log("Highlighted...");
            }
        }
    }

    // Move Disc to the another tower
    public void DeHighlight()
    {
        highlightController.GetComponent<S_HighlightController>().HighlightObject(isDisc, objNum, false); // Dehighlight Disc
        this.GetComponent<S_ObjectType>().isSelected = false; // Update object selection

        //Debug.Log("DeHighlighting Object");
    }
}
