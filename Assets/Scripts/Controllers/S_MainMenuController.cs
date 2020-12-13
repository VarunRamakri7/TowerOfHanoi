using UnityEngine;
using UnityEngine.SceneManagement;

public class S_MainMenuController : MonoBehaviour
{
    public GameObject rules; // Rules Text

    private void Start()
    {
        // Hide rules by default on start
        if (rules != null)
        {
            rules.SetActive(false);
        }
    }

    // Open the game when the player clicks on Play Button
    public void ClickPlay()
    {
        SceneManager.LoadScene("Sc_Game"); // Load Game Scene
    }

    // Open the help scene when player clicks the Help Button
    public void ClickHelp()
    {
        SceneManager.LoadScene("Sc_Help"); // Load Help Scene
    }

    // Go back to Main Menu when player clicks of Back Button
    public void ClickBack()
    {
        SceneManager.LoadScene("Sc_MainMenu"); // Load Main Menu Scene
    }

    // Display rules when the player clicks on Rule Button
    public void ClickRules()
    {
        rules.SetActive(!rules.activeSelf);
    }

    // Quit game when user clicks the Exit Button
    public void ClickExit()
    {
        Application.Quit(); // Quit application (will not work in editor)
    }
}
