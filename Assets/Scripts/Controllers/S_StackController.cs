﻿using System.Collections.Generic;
using UnityEngine;

public class S_StackController : MonoBehaviour
{
    const int STACK_SIZE = 5;

    // Represent each tower as a Stack
    public Stack<int> towerOne = new Stack<int>(STACK_SIZE);
    public Stack<int> towerTwo = new Stack<int>(STACK_SIZE);
    public Stack<int> towerThree = new Stack<int>(STACK_SIZE);

    public bool endGame = false; // End game status

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
                Debug.Log("Case 1...");
                Debug.Log("Stack One Count: " + towerOne.Count);
                // Check if top disc in tower is smaller than topmost disc
                if (towerOne.Count > 0) // If Stack is not empty
                {
                    Debug.Log("Stack not empty...");
                    // Check if topmost disc is larger than new disc
                    if (towerOne.Peek() < discToAddNum)
                    {
                        Debug.Log("New disc is smaller...");
                        discs[towerOne.Peek() - 1].GetComponent<S_ObjectType>().isTop = false; // Top most disc is no longer at top
                        discs[discToAddNum - 1].GetComponent<S_ObjectType>().isTop = true; // Make top disc as top

                        towerOne.Push(discToAddNum); // Push disc onto stack
                        isValid = true; // Disc addition is valid

                        //PrintStack(towerOne, 1); // Print Stack after removing
                    }
                }
                else
                {
                    Debug.Log("Adding to empty Stack...");
                    // Push into empty stack
                    discs[discToAddNum - 1].GetComponent<S_ObjectType>().isTop = true; // Make top disc as top

                    towerOne.Push(discToAddNum); // Push disc onto stack
                    isValid = true; // Disc addition is valid

                    //PrintStack(towerOne, 1); // Print Stack after removing
                }
                break;

            case 2:
                Debug.Log("Case 2...");
                Debug.Log("Stack Two Count: " + towerTwo.Count);
                // Check if top disc in tower is smaller than topmost disc
                if (towerTwo.Count > 0) // If Stack is not empty
                {
                    Debug.Log("Stack not empty...");
                    // Check if topmost disc is larger than new disc
                    if (towerTwo.Peek() < discToAddNum)
                    {
                        Debug.Log("New disc is smaller...");
                        discs[towerOne.Peek() - 1].GetComponent<S_ObjectType>().isTop = false; // Top most disc is no longer at top
                        discs[discToAddNum - 1].GetComponent<S_ObjectType>().isTop = true; // Make top disc as top

                        towerTwo.Push(discToAddNum);
                        isValid = true; // Disc addition is valid

                        //PrintStack(towerTwo, 2); // Print Stack after removing
                    }
                }
                else
                {
                    Debug.Log("Adding to empty Stack...");
                    // Push into empty stack
                    discs[discToAddNum - 1].GetComponent<S_ObjectType>().isTop = true; // Make top disc as top

                    towerTwo.Push(discToAddNum); // Push disc onto stack
                    isValid = true; // Disc addition is valid

                    //PrintStack(towerTwo, 2); // Print Stack after removing
                }
                break;

            case 3:
                Debug.Log("Case 3...");
                Debug.Log("Stack Three Count: " + towerThree.Count);
                // Check if top disc in tower is smaller than topmost disc
                if (towerThree.Count > 0) // If Stack is not empty
                {
                    Debug.Log("Stack not empty...");
                    // Check if topmost disc is larger than new disc
                    if (towerThree.Peek() < discToAddNum)
                    {
                        Debug.Log("New disc is smaller...");
                        discs[towerOne.Peek() - 1].GetComponent<S_ObjectType>().isTop = false; // Top most disc is no longer at top
                        discs[discToAddNum - 1].GetComponent<S_ObjectType>().isTop = true; // Make top disc as top

                        towerThree.Push(discToAddNum);
                        isValid = true; // Disc addition is valid

                        //PrintStack(towerThree, 3); // Print Stack after removing
                    }
                }
                else
                {
                    Debug.Log("Adding to empty Stack...");
                    // Push into empty stack
                    discs[discToAddNum - 1].GetComponent<S_ObjectType>().isTop = true; // Make top disc as top

                    towerThree.Push(discToAddNum); // Push disc onto stack
                    isValid = true; // Disc addition is valid

                    //PrintStack(towerThree, 3); // Print Stack after removing
                }
                break;
        }

        Debug.Log("Stack change is: " + isValid);

        return isValid;
    }

    // Remove disc from tower - Pop
    public void RemoveDisc(int towerNum, GameObject[] discs)
    {
        Debug.Log("In Remove...");
        //Debug.Log("Disc's tower num: " + towerNum);

        // Remove the topmost disc from this tower
        switch (towerNum)
        {
            case 1:
                Debug.Log("Removing from 1...");
                towerOne.Pop(); // Remove top disc
                //PrintStack(towerOne, 1); // Print Stack after removing
                Debug.Log("Tower 1 size: " + towerOne.Count);
                if (towerOne.Count > 0) // Check if stack is empty
                {
                    Debug.Log("Make next disc as top...");
                    discs[towerOne.Peek() - 1].GetComponent<S_ObjectType>().isTop = true; // Make next disc as top
                }
                else
                {
                    Debug.Log("Stack 1 size: " + towerOne.Count);
                    Debug.Log("Cannot retop 1...");
                }
                break;

            case 2:
                Debug.Log("Removing from 2...");
                towerTwo.Pop(); // Remove top disc
                //PrintStack(towerTwo, 2); // Print Stack after removing
                Debug.Log("Tower 2 size: " + towerTwo.Count);
                if (towerTwo.Count > 0) // Check if stack is empty
                {
                    Debug.Log("Make next disc " + towerTwo.Peek() + " as top...");
                    discs[towerTwo.Peek() - 1].GetComponent<S_ObjectType>().isTop = true; // Make next disc as top
                }
                else
                {
                    Debug.Log("Stack 2 size: " + towerTwo.Count);
                    Debug.Log("Cannot retop 2...");
                }
                break;

            case 3:
                Debug.Log("Removing from 3...");
                towerThree.Pop(); // Remove top disc
                //PrintStack(towerThree, 3); // Print Stack after removing
                Debug.Log("Tower 3 size: " + towerThree.Count);
                if (towerThree.Count > 0) // Check if stack is empty
                {
                    Debug.Log("Make next disc as top...");
                    discs[towerTwo.Peek() - 1].GetComponent<S_ObjectType>().isTop = true; // Make next disc as top
                }
                else
                {
                    Debug.Log("Stack 3 size: " + towerThree.Count);
                    Debug.Log("Cannot retop 3...");
                }
                break;
        }
    }

    // Key detection for debugging
    private void Update()
    {
        // Check Game complete state
        if (towerOne.Count == STACK_SIZE) // If all discs are in tower 1
        {
            endGame = CheckComplettion(towerOne);
        }
        else if (towerTwo.Count == STACK_SIZE) // If all discs are in tower 2
        {
            endGame = CheckComplettion(towerTwo);
        }
        else if (towerThree.Count == STACK_SIZE) // If all discs are in tower 3
        {
            endGame = CheckComplettion(towerThree);
        }

        // End game if it is complete
        if (endGame)
        {
            Debug.Log("Game Over. You have won!");
        }


        // Use keys to print stack contents
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1 Pressed...");
            // Print Tower One
            PrintStack(towerOne, 1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("2 Pressed...");
            // Print Tower Two
            PrintStack(towerTwo, 2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("3 Pressed...");
            // Print Tower Three
            PrintStack(towerThree, 3);
        }

        // Clear stack contents
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("1 Cleared...");
            // Clear Tower One
            towerOne.Clear();
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("2 Cleared...");
            // Clear Tower Two
            towerTwo.Clear();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("3 Cleared...");
            // Clear Tower Three
            towerThree.Clear();
        }

    }

    // Check stack to see if all discs have been moved to a new tower
    public bool CheckComplettion(Stack<int> tower)
    {
        bool isComplete = false; // If the player has moved all discs to a new tower

        // Iterate through Stack and check if order is correct
        Stack<int> copy = tower;
        int[] temp = new int[STACK_SIZE];

        int i = 0;
        foreach (int disc in tower) // Iterate through copy of stack
        {
            // Copy all contents of the stack into an array
            temp[i++] = copy.Pop();
        }

        // Check if array contents are in descending order
        for(i = 0; i < STACK_SIZE - 1; i++)
        {
            if (temp[i] != (1 + temp[i + 1]))
            {
                Debug.Log("Discs in wrong order...");
                break;
            }
            else
            {
                Debug.Log("Discs in correct order...");
                isComplete = true;
            }
        }

        return isComplete;
    }

    // Print Stack
    public void PrintStack(Stack<int> tower, int num)
    {
        Debug.Log("Tower " + num + " contains...");
        foreach(int disc in tower)
        {
            Debug.Log("Disc " + disc);
        }
    }
}
