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
    public bool AddDisc(int towerNum, int discToAdd)
    {
        bool isValid = false; // Trak whether disc move is valid

        // Add disc to tower. Make it the top
        switch (towerNum)
        {
            case 1:
                // Check if top disc in tower is smaller than topmost disc
                if (towerOne.Peek() > discToAdd)
                {
                    // Make disc at top as not top
                    towerOne.Push(discToAdd);
                    // Make top disc as top
                    isValid = true; // Disc addition is valid
                }
                break;

            case 2:
                // Check if top disc in tower is smaller than topmost disc
                if (towerTwo.Peek() > discToAdd)
                {
                    // Make disc at top as not top
                    towerTwo.Push(discToAdd);
                    // Make top disc as top
                    isValid = true; // Disc addition is valid
                }
                break;

            case 3:
                // Check if top disc in tower is smaller than topmost disc
                if (towerThree.Peek() > discToAdd)
                {
                    // Make disc at top as not top
                    towerThree.Push(discToAdd);
                    // Make top disc as top
                    isValid = true; // Disc addition is valid
                }
                break;
        }

        return isValid;
    }

    // Remove disc from tower - Pop
    public void RemoveDisc(int towerNum)
    {
        // Remove the topmost disc from this tower
        switch (towerNum)
        {
            case 1: towerOne.Pop();
                    // Make next disc as top
                break;

            case 2: towerTwo.Pop();
                    // Make next disc as top
                break;

            case 3: towerThree.Pop();
                    // Make next disc as top
                break;
        }
    }
}
