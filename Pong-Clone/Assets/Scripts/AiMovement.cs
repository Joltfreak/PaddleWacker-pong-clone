using UnityEngine;

public class AiMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4f;
    Transform TargetPosition;

    // Update is called once per frame
    void Update()
    {
        movePaddle();
    }

    void movePaddle()
    {
        TargetPosition = GameObject.Find("Ball").transform;
        if(TargetPosition == null)
        {
            return;
        }

        if(TargetPosition.position.y > transform.position.y)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        else if(TargetPosition.position.y < transform.position.y)
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
    }
}
