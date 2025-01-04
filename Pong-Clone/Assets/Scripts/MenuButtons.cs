using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{   
    [SerializeField] GameObject gameModesDisplay;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip buttonClick;
    [SerializeField] GameObject MapsDisplayPVP;
    [SerializeField] GameObject MapsDisplayPVE;

    private void Start()
    {
        gameModesDisplay.SetActive(false);
        MapsDisplayPVP.SetActive(false);
        MapsDisplayPVE.SetActive(false);
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
        MapsDisplayPVP.SetActive(false);
        MapsDisplayPVE.SetActive(false);
    }

    public void SelectMapMenuPvP()
    {
        // This will start the game
        audioSource.PlayOneShot(buttonClick);
        gameModesDisplay.SetActive(false);
        MapsDisplayPVP.SetActive(true);
    }

    public void SelectMapMenuPvE()
    {
        // This will start the game
        audioSource.PlayOneShot(buttonClick);
        gameModesDisplay.SetActive(false);
        MapsDisplayPVE.SetActive(true);
    }

    public void StartPlayerVsAi(int gameMode)
    {
        // This will start the game
        audioSource.PlayOneShot(buttonClick);
        SceneManager.LoadSceneAsync(gameMode);
    }

    public void StartPlayerVsPlayer(int gameMode)
    {
        // This will start the game
        audioSource.PlayOneShot(buttonClick);
        SceneManager.LoadSceneAsync(gameMode);
    }
}