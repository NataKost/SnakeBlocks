using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SmashScores : MonoBehaviour
{
    public int smashScores;
    public Moving snakeHead;
    public Material material;
    public int min;
    public int max;

    private void Start()
    {
        smashScores = Random.Range(min, max);
    }

    private void Update()
    {
        GetComponent<Renderer>().material.SetFloat("_ScoreSh", smashScores);
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
