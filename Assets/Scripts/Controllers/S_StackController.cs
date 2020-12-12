using System.Collections.Generic;
using UnityEngine;

public class S_StackController : MonoBehaviour
{
    const int STACK_SIZE = 5;

    // Represent each tower as a Stack
    public Stack<int> towerOne = new Stack<int>(STACK_SIZE);
    public Stack<int> towerTwo = new Stack<int>(STACK_SIZE);
    public Stack<int> towerThree = new Stack<int>(STACK_SIZE);

    // Start is called before the first frame update
    void Start()
    {
        // Push discs onto Tower Two when starting game
        for (int i = 0; i < STACK_SIZE; i++)
        {
            towerTwo.Push(i + 1); // Tower two contains disc at game start
        }
    }

    // Add disc to new tower - Push
    public bool AddDisc(int towerNum, int discToAddNum, GameObject[] discs)
    {
        bool isValid = false; // Trak whether disc move is valid

        // Add disc to tower. Make it the top
        switch (towerNum)
        {
            case 1:
                // Check if top disc in tower is smaller than topmost disc
                if (towerOne.Count == 0 || towerOne.Peek() > discToAddNum)
                {
                    discs[towerOne.Peek()].GetComponent<S_ObjectType>().isTop = false; // Top most disc is no longer at top
                    discs[discToAddNum].GetComponent<S_ObjectType>().isTop = true; // Make top disc as top

                    towerOne.Push(discToAddNum); // Push disc onto stack
                    isValid = true; // Disc addition is valid
                }
                break;

            case 2:
                // Check if top disc in tower is smaller than topmost disc
                if (towerTwo.Count == 0 || towerTwo.Peek() > discToAddNum)
                {
                    discs[towerOne.Peek()].GetComponent<S_ObjectType>().isTop = false; // Top most disc is no longer at top
                    discs[discToAddNum].GetComponent<S_ObjectType>().isTop = true; // Make top disc as top

                    towerTwo.Push(discToAddNum);
                    isValid = true; // Disc addition is valid
                }
                break;

            case 3:
                // Check if top disc in tower is smaller than topmost disc
                if (towerThree.Count == 0 || towerThree.Peek() > discToAddNum)
                {
                    discs[towerOne.Peek()].GetComponent<S_ObjectType>().isTop = false; // Top most disc is no longer at top
                    discs[discToAddNum].GetComponent<S_ObjectType>().isTop = true; // Make top disc as top

                    towerThree.Push(discToAddNum);
                    isValid = true; // Disc addition is valid
                }
                break;
        }

        Debug.Log("Stack change is: " + isValid);

        return isValid;
    }

    // Remove disc from tower - Pop
    public void RemoveDisc(int towerNum, GameObject[] discs)
    {
        // Remove the topmost disc from this tower
        switch (towerNum)
        {
            case 1: towerOne.Pop(); // Remove top disc
                discs[towerOne.Peek()].GetComponent<S_ObjectType>().isTop = true; // Make next disc as top
                break;

            case 2: towerTwo.Pop(); // Remove top disc
                discs[towerTwo.Peek()].GetComponent<S_ObjectType>().isTop = true; // Make next disc as top
                break;

            case 3: towerThree.Pop(); // Remove top disc
                discs[towerTwo.Peek()].GetComponent<S_ObjectType>().isTop = true; // Make next disc as top
                break;
        }
    }

    // Check stack to see if all discs have been moved to a new tower
    public bool CheckComplettion(Stack<int> tower)
    {
        bool isComplete = false;

        // Iterate through Stack and check if order is correct


        return isComplete;
    }
}
