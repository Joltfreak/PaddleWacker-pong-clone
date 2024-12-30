using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInputHandling : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] bool isPlayerOne;
    [SerializeField] GameObject PauseMenu;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    // Update is called once per frame

    private void Start()
    {
        PauseMenu.SetActive(false);
    }

    void Update()
    {
        if(isPlayerOne)
        {
            handlePlayer1Movement();
        }
        else
        {
            handlePlayer2Movement();
        }

        handlePauseMenu();
    }

    void handlePauseMenu()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            audioSource.PlayOneShot(audioClip);
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;

        audioSource.PlayOneShot(audioClip);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
        audioSource.PlayOneShot(audioClip);
    }

    void handlePlayer1Movement()
    {
        // range to clamp is 4.15 to -4.15

        if(transform.position.y < 3.45f && Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        else if(transform.position.y > -4.15f && Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
    }

    void handlePlayer2Movement()
    {
        // range to clamp is 4.15 to -4.15

        if(transform.position.y < 3.45f && Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        else if(transform.position.y > -4.15f && Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
    }
}
