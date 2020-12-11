using UnityEngine;

public class S_MoveController : MonoBehaviour
{
    const int NUM_DISCS = 5; // Total number of Discs
    const int NUM_TOWERS = 3; // Total number of Towers

    public GameObject highlightController; // Highlight Controller object in game

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

        switch (selTowerNum)
        {
            case 1: discs[selDiscNum - 1].transform.position = spawnPointsOne[selDiscNum - 1].position;
                /*highlightController.GetComponent<S_HighlightController>().twoSelected = false; // Reset selections
                discs[selDiscNum - 1].GetComponent<S_SelectObject>().DeHighlight();
                discs[selDiscNum - 1].GetComponent<S_ObjectType>().currentTower = selDiscNum - 1;
                Debug.Log("Moving Disc " + selDiscNum);*/
                DeselectCleanup(selDiscNum, selTowerNum);
                break;

            case 2:
                discs[selDiscNum - 1].transform.position = spawnPointsTwo[selDiscNum - 1].position;
                /*highlightController.GetComponent<S_HighlightController>().twoSelected = false;
                discs[selDiscNum - 1].GetComponent<S_SelectObject>().DeHighlight();
                discs[selDiscNum - 1].GetComponent<S_ObjectType>().currentTower = selDiscNum - 1;
                Debug.Log("Moving Disc " + selDiscNum);*/
                DeselectCleanup(selDiscNum, selTowerNum);
                break;

            case 3:
                discs[selDiscNum - 1].transform.position = spawnPointsThree[selDiscNum - 1].position;
                /*highlightController.GetComponent<S_HighlightController>().twoSelected = false;
                discs[selDiscNum - 1].GetComponent<S_SelectObject>().DeHighlight();
                discs[selDiscNum - 1].GetComponent<S_ObjectType>().currentTower = selDiscNum - 1;
                Debug.Log("Moving Disc " + selDiscNum);*/
                DeselectCleanup(selDiscNum, selTowerNum);
                break;
        }
    }

    // Reset selections
    public void DeselectCleanup(int discNum, int towerNum)
    {
        highlightController.GetComponent<S_HighlightController>().twoSelected = false; // Reset selections
        discs[discNum - 1].GetComponent<S_SelectObject>().DeHighlight();
        towers[towerNum - 1].GetComponent<S_SelectObject>().DeHighlight();
        discs[discNum - 1].GetComponent<S_ObjectType>().currentTower = discNum - 1;
        highlightController.GetComponent<S_HighlightController>().selectedDisc = -1;
        highlightController.GetComponent<S_HighlightController>().selectedTower = -1;
        Debug.Log("Moving Disc " + discNum);
    }
}