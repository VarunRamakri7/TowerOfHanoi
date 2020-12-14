using UnityEngine;
using UnityEngine.UI;

public class S_HighlightController : MonoBehaviour
{
    public Image[] discIndicators = new Image[5]; // All 5 disc's indicators
    public Image[] towerIndicators = new Image[3]; // All 3 tower's indicators
    public int selectedDisc = -1; // Number of Disc that is currently selected, -1 if none
    public int selectedTower = -1; // Number of Tower that is currently selected, -1 if none

    public bool twoSelected;

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

    private void Update()
    {
        // If max objects have been selected
        twoSelected = (selectedDisc != -1) && (selectedTower != -1);
    }

    public void HighlightObject(bool isDisc, int indicatorNum, bool highlight)
    {
        // Check if the gameobject is a disc
        if (isDisc)
        {
            // Hide previously selected disc
            if (selectedDisc != -1)
            {
                discIndicators[selectedDisc - 1].gameObject.SetActive(!highlight); // Highlight the disc
            }

            selectedDisc = indicatorNum;
            discIndicators[indicatorNum - 1].gameObject.SetActive(highlight); // Highlight the disc

            //if (highlight) Debug.Log("Disc selected: " + selectedDisc); // DEBUG
        }
        else
        {
            // Hide previously selected Tower
            if (selectedTower != -1)
            {
                towerIndicators[selectedTower - 1].gameObject.SetActive(!highlight); // Highlight the disc
            }

            selectedTower = indicatorNum;
            towerIndicators[indicatorNum - 1].gameObject.SetActive(highlight); // Highlight the tower

            //if (highlight)  Debug.Log("Tower selected: " + selectedTower); // DEBUG
        }
    }
}
