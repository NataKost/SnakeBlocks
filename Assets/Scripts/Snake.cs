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
    public List<Vector3> ballsPositions;

    private float distance = 0.5f;

    private void Awake()
    {
        ballsPositions.Add (player.position);
    }

    private void Update()
    {
        Tail();
    }

    private void OnTriggerEnter(Collider other)
    {
        prevScores = scores;
        scores++;

        GameObject ball = Instantiate(ballPref[0], new Vector3(ballsPositions[ballsPositions.Count - 1].x, ballsPositions[ballsPositions.Count - 1].y, ballsPositions[ballsPositions.Count - 1].z - distance), Quaternion.identity, transform);

        for (int i = prevScores; i < scores; i++)
        {
            snakeBalls.Add(ball);
            ballsPositions.Add(ball.transform.position);
        }
    }

    private void Tail ()
    {
        float sqrDist = Mathf.Sqrt(distance);
        Vector3 prevPos = transform.position;

        foreach (var ball in snakeBalls)
        {
            if ((ball.transform.position - prevPos).sqrMagnitude > sqrDist)
            {
                Vector3 currentPos = ball.transform.position;
                ball.transform.position = prevPos * Time.deltaTime;
                prevPos = currentPos;
            }
            else
            {
                return;
            }
        }
    }
}
