using UnityEngine;
using UnityEngine.UI;

public class S_TimeController : MonoBehaviour
{
    public Text time; // Timer that counts up
    public Text movesMade; // Shows the number of moves made by user
    public int moves = 0; // Moves made counter

    private float seconds = 0.0f; // To track seconds
    private float minutes = 0.0f; // To track minutes

    public bool canStart = false; // True if user steps on pedestal

    void Update()
    {
        // Trigger only after user steps on pedestal
        if (canStart)
        {
            // Use Time.deltaTime to have a clock
            seconds += Time.deltaTime;
            if (seconds > 60)
            {
                // Increment minutes every 60 seconds
                minutes += 1;
                seconds = 0;
            }

            time.text = minutes + ":" + seconds;
            movesMade.text = moves.ToString();
        }
    }
}
