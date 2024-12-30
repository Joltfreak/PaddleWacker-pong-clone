using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{   
    GameObject gameModesDisplay;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip buttonClick;

    private void Start()
    {
        gameModesDisplay = GameObject.Find("GameModesDisplay");
        gameModesDisplay.SetActive(false);
    }

    // TODO: Make a sub-menu for game different game modes
    public void DisplayGameModes()
    {
        // TODO: Display game modes
        audioSource.PlayOneShot(buttonClick);
        gameModesDisplay.SetActive(true);
    }

    public void BackToMainMenu()
    {
        // TODO: Make a method to go back to the main menu
        audioSource.PlayOneShot(buttonClick);
        gameModesDisplay.SetActive(false);
    }

    public void StartPlayerVsAi(int gameMode)
    {
        // This will start the game
        audioSource.PlayOneShot(buttonClick);
        SceneManager.LoadScene(gameMode);
    }

    public void StartPlayerVsPlayer(int gameMode)
    {
        // This will start the game
        audioSource.PlayOneShot(buttonClick);
        SceneManager.LoadScene(gameMode);
    }
}