using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBallPluss : MonoBehaviour
{
    public Moving snakeHead;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out snakeHead))
        {
            snakeHead.AddBall();
            Destroy(this.gameObject);
        }
    }
}
