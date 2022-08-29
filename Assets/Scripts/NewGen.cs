using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGen : MonoBehaviour
{
    public Transform snakeHead;
    public Transform ballPref;

    private List <Transform> snakeBalls = new List<Transform>();
    private List <Vector3> ballsPositions = new List<Vector3>();


    public float ballDiametr = 1.0f;

    private void Awake()
    {
        ballsPositions.Add(snakeHead.position);
    }

    private void Update()
    {
        float distHeadBall = (snakeHead.position - ballsPositions[0]).magnitude;

        if(distHeadBall > ballDiametr)
        {
            Vector3 direction = (snakeHead.position - ballsPositions[0]).normalized;

            ballsPositions.Insert(0, ballsPositions[0] + direction * ballDiametr);
            ballsPositions.RemoveAt(ballsPositions.Count - 1);

            distHeadBall -= ballDiametr;
        }

        for (int i = 0; i < snakeBalls.Count; i++)
        {
            snakeBalls[i].position = Vector3.Lerp (ballsPositions[i + 1], ballsPositions[i], distHeadBall / ballDiametr);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Transform ball = Instantiate(ballPref, ballsPositions[ballsPositions.Count - 1], Quaternion.identity, transform);
        snakeBalls.Add(ball);
        ballsPositions.Add (ball.position);
    }
}
