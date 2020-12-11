using UnityEngine;
using UnityEngine.UI;

public class S_HighlightController : MonoBehaviour
{
    public Image[] discIndicators = new Image[5]; // All 5 disc's indicators
    public Image[] towerIndicators = new Image[3]; // All 3 tower's indicators
    public int selectedDisc = -1; // Number of Disc that is currently selected, -1 if none
    public int selectedTower = -1; // Number of Tower that is currently selected, -1 if none

    // Start is called before the first frame update
    void Start()
    {
        // Hide all disc indicators
        foreach(Image image in discIndicators)
        {
            image.gameObject.SetActive(false);
        }
        
        // Hide all tower indicators
        foreach (Image image in towerIndicators)
        {
            image.gameObject.SetActive(false);
        }
    }

    public void HighlightObject(bool isDisc, int indicatorNum)
    {
        // Check if the gameobject is a disc
        if (isDisc)
        {
            discIndicators[indicatorNum - 1].gameObject.SetActive(true); // Highlight the disc
        }
        else
        {
            towerIndicators[indicatorNum - 1].gameObject.SetActive(true); // Highlight the tower
        }
    }
}
