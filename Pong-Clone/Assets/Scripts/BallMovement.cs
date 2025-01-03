using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float ballMoveSpeed = 5f;
    private Vector3 currentDirection;
    private float randomOffset;
    private AudioSource audioSource;
    [SerializeField] AudioClip hitsound;
    [SerializeField] Rigidbody2D rb;

    private void Start() 
    {
        currentDirection = -transform.right;
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        MoveBall(currentDirection);
    }

    void MoveBall(Vector3 direction)
    {
        //transform.position += direction.normalized * ballMoveSpeed * Time.deltaTime;
        rb.velocity = direction.normalized * ballMoveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("Paddle"))
        {
            
            Vector3 positionHit = collision.GetContact(0).point;
            Vector3 reflection = Vector3.Reflect(currentDirection, collision.GetContact(0).normal);
            Vector3 paddlesPos = collision.gameObject.transform.position;

            if(positionHit.y > paddlesPos.y)
            {
                print("Hit higher");
                //randomOffset = Random.Range(0, 20);
                reflection.y += 0.5f;
                playSound();
            }
            else if(positionHit.y < paddlesPos.y)
            {
                print("Hit lower");
                //randomOffset = Random.Range(0, 20);
                reflection.y -= 0.5f;
                playSound();
            }
            ballMoveSpeed += 0.5f;
            currentDirection = reflection.normalized;
            // print("is colliding");
        }
        
        if(collision.gameObject.CompareTag("Wall"))
        {
            currentDirection.y = -currentDirection.y;
            playSound();
        }

        if(collision.gameObject.CompareTag("ObstacleX"))
        {
            currentDirection.x = -currentDirection.x;
            playSound();
        }

        if(collision.gameObject.CompareTag("ObstacleY"))
        {
            currentDirection.y = -currentDirection.y;
            playSound();
        }
    }

    void playSound()
    {
        audioSource.PlayOneShot(hitsound);
        audioSource.volume = Random.Range(0.125f, 0.2f);
        audioSource.pitch = Random.Range(0.85f, 1f);
    }
    public void ResetDirection()
    {
        currentDirection = -transform.right;
    }
}
