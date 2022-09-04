using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashScores : MonoBehaviour
{
    public int smashScores;
    public Moving snakeHead;

    private void Start()
    {
        smashScores = Random.Range(1, 5);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out snakeHead))
        {
            smashScores--;
            if (smashScores <= 0)
            {
                Destroy(this.gameObject);
            }
        }
        else if (!collision.gameObject.TryGetComponent(out snakeHead))
        {
            return;
        }
    }
}
