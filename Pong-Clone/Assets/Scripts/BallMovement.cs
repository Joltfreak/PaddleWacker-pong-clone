using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float ballMoveSpeed = 5f;
    private Vector3 currentDirection;
    private float randomOffset;

    private void Start() 
    {
        currentDirection = -transform.right;
    }

    void Update()
    {
        MoveBall(currentDirection);
    }

    void MoveBall(Vector3 direction)
    {
        transform.position += direction.normalized * ballMoveSpeed * Time.deltaTime;
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
            }
            else if(positionHit.y < paddlesPos.y)
            {
                print("Hit lower");
                //randomOffset = Random.Range(0, 20);
                reflection.y -= 0.5f;
            }
            ballMoveSpeed += 0.5f;
            currentDirection = reflection.normalized;
            // print("is colliding");
        }
        
        if(collision.gameObject.CompareTag("Wall"))
        {
            currentDirection.y = -currentDirection.y;
            print("Hit Wall");
        }
    }
}
