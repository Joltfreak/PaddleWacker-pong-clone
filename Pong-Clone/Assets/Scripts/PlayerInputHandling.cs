using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandling : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        handlePlayerMovement();
    }

    void handlePlayerMovement()
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
}
