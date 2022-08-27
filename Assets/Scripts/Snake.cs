using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{

    public int scores = 0;
    public int prevScores = 0;
    public Transform player;
    public List<GameObject> ballPref;
    public List<GameObject> snakeBalls;

    private void OnTriggerEnter(Collider other)
    {
        prevScores = scores;
        scores++;

        for (int i = prevScores ; i < scores ; i++)
        {
            GameObject snakeBall = Instantiate(ballPref[0], transform);
            snakeBalls.Add(snakeBall);
            
            if (i > 0)
            {
                snakeBall.transform.localScale = new Vector3(1, 1, 1);
                snakeBall.transform.localPosition = new Vector3(snakeBalls[i - 1].transform.localPosition.x, snakeBalls[i - 1].transform.localPosition.y, snakeBalls[i - 1].transform.localPosition.z - 1f);
            }
            else
            {
                snakeBall.transform.localScale = new Vector3(1, 1, 1);
                snakeBall.transform.localPosition = new Vector3(0, 0,-1f);
            }
        }
    }
}
