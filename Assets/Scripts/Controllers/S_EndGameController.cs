using UnityEngine;
using UnityEngine.UI;

public class S_EndGameController : MonoBehaviour
{
    public Text actualTime; // Actual Time Text
    public Text movesMade; // Moves Made Text
    public GameObject inGameCanvas; // Normal Game Canvas
    public GameObject endGameCanvas; // End Game Canvas
    public GameObject environment; // Level environment

    public GameObject timeController; // Time controller in game

    private void Start()
    {
        endGameCanvas.SetActive(false);
    }

    public void EndGame()
    {
        // Update final time and moves made
        actualTime.text = timeController.GetComponent<S_TimeController>().time.text; // Get final time
        timeController.GetComponent<S_TimeController>().canStart = false; // Stop timer
        movesMade.text = timeController.GetComponent<S_TimeController>().moves.ToString(); // Get final moves made

        // Hide all previous assets and show Game over
        inGameCanvas.SetActive(false); // Hide normal canvas
        environment.SetActive(false); // Hide environment

        endGameCanvas.SetActive(true); // Show end Game canvas
    }
}
