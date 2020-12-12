using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S_MoveController : MonoBehaviour
{
    const int NUM_DISCS = 5; // Total number of Discs
    const int NUM_TOWERS = 3; // Total number of Towers

    public GameObject highlightController; // Highlight Controller object in game
    public GameObject stackController; // Stack controller for tower and disc movement

    public Text invalidMove; // Warning text
    public Transform[] spawnPointsOne = new Transform[NUM_DISCS]; // Spawn points on Tower One
    public Transform[] spawnPointsTwo = new Transform[NUM_DISCS]; // Spawn points on Tower Two
    public Transform[] spawnPointsThree = new Transform[NUM_DISCS]; // Spawn points on Tower Three
    public GameObject[] discs = new GameObject[NUM_DISCS]; // All discs in game
    public GameObject[] towers = new GameObject[NUM_TOWERS]; // All towers in game
    //public Transform newDiscPosition; // New position of Disc

    private void Update()
    {
        // Move disc only if disc and tower are selected
        if (highlightController.GetComponent<S_HighlightController>().twoSelected)
        {
            MoveDisc();
        }
    }

    // Move disc from current tower to new tower
    public void MoveDisc()
    {
        int selDiscNum = highlightController.GetComponent<S_HighlightController>().selectedDisc; // Get selected disc number
        int selTowerNum = highlightController.GetComponent<S_HighlightController>().selectedTower; // Get selected tower number

        // Check if disc is topmost disc of a tower
        if (discs[selDiscNum - 1].GetComponent<S_ObjectType>().isTop)
        {
            // Move disc to corresponding Tower
            switch (selTowerNum)
            {
                // Tower One
                case 1:
                    // Check if move is valid
                    if (stackController.GetComponent<S_StackController>().AddDisc(selDiscNum, selDiscNum, discs))
                    {
                        stackController.GetComponent<S_StackController>().RemoveDisc(selDiscNum, discs);// Remove disc from current stack
                        discs[selDiscNum - 1].transform.position = spawnPointsOne[selDiscNum - 1].position; // Move disc to new position
                        DeselectCleanup(selDiscNum, selTowerNum); // Cleanup highlights
                    }
                    else
                    {
                        ShowWarning(); // Invalid move
                        DeselectCleanup(selDiscNum, selTowerNum); // Cleanup highlights
                    }
                    break;

                // Tower Two
                case 2:
                    // Check if move is valid
                    if (stackController.GetComponent<S_StackController>().AddDisc(selDiscNum, selDiscNum, discs))
                    {
                        stackController.GetComponent<S_StackController>().RemoveDisc(selDiscNum, discs);// Remove disc from current stack
                        discs[selDiscNum - 1].transform.position = spawnPointsTwo[selDiscNum - 1].position; // Move disc to new position
                        DeselectCleanup(selDiscNum, selTowerNum); // Cleanup highlights
                    }
                    else
                    {
                        ShowWarning(); // Invalid move
                        DeselectCleanup(selDiscNum, selTowerNum); // Cleanup highlights
                    }
                    break;

                // Tower Three
                case 3:
                    if (stackController.GetComponent<S_StackController>().AddDisc(selDiscNum, selDiscNum, discs))
                    {
                        stackController.GetComponent<S_StackController>().RemoveDisc(selDiscNum, discs);// Remove disc from current stack
                        discs[selDiscNum - 1].transform.position = spawnPointsThree[selDiscNum - 1].position; // Move disc to new position
                        DeselectCleanup(selDiscNum, selTowerNum); // Cleanup highlights
                    }
                    else
                    {
                        ShowWarning(); // Invalid move
                        DeselectCleanup(selDiscNum, selTowerNum); // Cleanup highlights
                    }
                    break;
            }
        }
        else
        {
            ShowWarning(); // Invalid move
        }
    }

    // Reset selections
    public void DeselectCleanup(int discNum, int towerNum)
    {
        highlightController.GetComponent<S_HighlightController>().twoSelected = false; // Reset selections
        discs[discNum - 1].GetComponent<S_SelectObject>().DeHighlight(); // Dehighlight disc
        towers[towerNum - 1].GetComponent<S_SelectObject>().DeHighlight(); // Dehighlight tower
        discs[discNum - 1].GetComponent<S_ObjectType>().currentTower = discNum - 1; // Change current tower of Disc
        highlightController.GetComponent<S_HighlightController>().selectedDisc = -1; // Reset selected disc
        highlightController.GetComponent<S_HighlightController>().selectedTower = -1; // Reset selected tower
        Debug.Log("Moving Disc " + discNum);
    }

    public void ShowWarning()
    {
        invalidMove.gameObject.SetActive(true); // Make warning visible
        StartCoroutine(Timer()); // Show for 3 seconds
        invalidMove.gameObject.SetActive(false); // Make warning invisible
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
    }
}