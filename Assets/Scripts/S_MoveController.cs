using UnityEngine;

public class S_MoveController : MonoBehaviour
{
    const int NUM_DISCS = 5; // Total number of Discs

    public Transform[] spawnPointsOne = new Transform[NUM_DISCS]; // Spawn points on Tower One
    public Transform[] spawnPointsTwo = new Transform[NUM_DISCS]; // Spawn points on Tower Two
    public Transform[] spawnPointsThree = new Transform[NUM_DISCS]; // Spawn points on Tower Three
    public GameObject[] discs = new GameObject[NUM_DISCS]; // All discs in game
    public Transform newDiscPosition; // New position of Disc


}