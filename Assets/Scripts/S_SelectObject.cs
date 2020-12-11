using UnityEngine;
using UnityEngine.UI;

public class S_SelectObject : MonoBehaviour
{
    public GameObject highlight; // Image attached to this object

    // Get the Image component on Start
    /*private void Start()
    {
        highlight = transform.GetChild(3).gameObject; // Get Image attached to object
        Debug.Log("Got Image...");
    }*/

    // Check if user interacts with this object
    private void OnMouseOver()
    {
        //Debug.Log("Mouse Over...");

        // Check if user clicks on object
        if (Input.GetMouseButtonDown(0))
        {
            // Highlight object if user clicks on it
            highlight.SetActive(true);
            this.GetComponent<S_ObjectType>().isSelected = true; // Update object selection
            Debug.Log("Highlighted...");
        }
    }

    // Move Disc to the another tower
    private void MoveDisc()
    {

    }
}
