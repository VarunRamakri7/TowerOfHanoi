using UnityEngine;
using UnityEngine.UI;

public class S_TimeController : MonoBehaviour
{
    public Text time; // Timer that counts up
    public Text movesMade; // Shows the number of moves made by user
    public int moves; // Moves made counter

    private float seconds = 0.0f;
    private float minutes = 0.0f;

    void Update()
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

    }
}
