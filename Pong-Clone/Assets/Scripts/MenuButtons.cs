using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{   
    // TODO: Make a sub-menu for game different game modes
    public void DisplayGameModes()
    {
        // TODO: Display game modes

    }

    public void BackToMainMenu()
    {
        // TODO: Make a method to go back to the main menu

    }

    public void StartGame(int gameMode)
    {
        // This will start the game
        SceneManager.LoadScene(gameMode);
    }
}