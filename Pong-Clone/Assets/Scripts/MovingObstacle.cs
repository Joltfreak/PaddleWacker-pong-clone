using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    Vector3 startPos;
    [SerializeField] float frequency = 5f;
    [SerializeField] float magnitude = 5f;
    [SerializeField] float offset = 0f;
    [SerializeField] bool isMovingUp;

    private void Start() 
    {
        startPos = transform.position;
    }

    void Update()
    {
        moveObstacle();
    }

    void moveObstacle()
    {
        if(isMovingUp)
        {
            transform.position = startPos + transform.up * Mathf.Sin(Time.time * frequency + offset) * magnitude;
        }
        else
        {
            transform.position = startPos - transform.up * Mathf.Sin(Time.time * frequency + offset) * magnitude;
        }
    }
}
