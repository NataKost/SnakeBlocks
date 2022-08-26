using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{

    private int scores = 0;
    public Transform player;
    public List<GameObject> snakeBalls;

    private void OnTriggerEnter(Collider other)
    {
        int temp = scores;
        scores++;

        for (int i = 0; i < (scores - temp); i++)
        {
            GameObject snakeBall = Instantiate(snakeBalls[0], transform);
            snakeBalls.Add(snakeBall);

            if (i > 0)
            {
                snakeBall.transform.localPosition = new Vector3(snakeBalls[i - 1].transform.position.x, snakeBalls[i - 1].transform.position.y, snakeBalls[i - 1].transform.position.z - 0.5f);
            }
            else
            {
                snakeBall.transform.localPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 0.5f);
            }
        }
    }
}
