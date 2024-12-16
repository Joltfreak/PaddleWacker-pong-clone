using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] int WaitTime = 3;
    //[SerializeField] GameObject BallPrefab;
    [SerializeField] GameObject Ball;

    public IEnumerator spawnBall()
    {
        yield return new WaitForSeconds(WaitTime);
        Ball.transform.position = transform.position;
        Ball.GetComponent<BallMovement>().ResetDirection();
        //Instantiate(BallPrefab, transform.position, Quaternion.identity);
    }
}
