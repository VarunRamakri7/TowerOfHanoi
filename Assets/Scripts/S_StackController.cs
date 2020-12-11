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
    public void AddDisc(int towerNum)
    {

    }

    // Remove disc from tower - Pop
    public void RemoveDisc(int towerNum)
    {

    }
}
