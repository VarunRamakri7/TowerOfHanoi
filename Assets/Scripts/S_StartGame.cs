using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_StartGame : MonoBehaviour
{
    public Transform position; // Position that camera needs to go to
    public Camera mainCamera; // Main camera in scene
    public GameObject player; // Player character in scene

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered...");

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Starting Game...");

            mainCamera.gameObject.GetComponent<S_MouseLook>().enabled = false; // Deactivate Script
            Cursor.lockState = CursorLockMode.None; // Unlock cursor
            mainCamera.transform.SetParent(null); // Make camera independant

            // Change camera's transform
            mainCamera.transform.position = position.position;
            mainCamera.transform.rotation = position.rotation;

            // Deactivate player
            player.SetActive(false);
            mainCamera.gameObject.SetActive(true);
        }
    }
}
