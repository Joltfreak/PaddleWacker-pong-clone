using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    Vector3 startPos;
    [SerializeField] float frequency = 5f;
    [SerializeField] float magnitude = 5f;
    [SerializeField] float offset = 0f;

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
        transform.position = startPos + transform.up * Mathf.Sin(Time.time * frequency + offset) * magnitude;
    }
}
