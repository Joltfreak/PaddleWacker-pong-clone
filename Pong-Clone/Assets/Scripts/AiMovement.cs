using UnityEngine;

public class AiMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4f;
    Transform TargetPosition;

    // Update is called once per frame
    void Update()
    {
        movePaddle();
        print(TargetPosition);
        GameObject ball = GameObject.Find("Ball");
        if(ball != null)
        {
            TargetPosition = ball.transform;
        }
        else
        {
            TargetPosition = null;
        }
    }

    void movePaddle()
    {
        if(TargetPosition == null)
        {
            return;
        }

        if(TargetPosition.position.y > transform.position.y && transform.position.y < 3.45f)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        else if(TargetPosition.position.y < transform.position.y && transform.position.y > -4.15f)
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
    }
}