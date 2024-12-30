using UnityEngine;

public class PlayerInputHandling : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] bool isPlayerOne;

    // Update is called once per frame
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
