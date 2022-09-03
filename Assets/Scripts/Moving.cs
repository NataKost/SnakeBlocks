using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moving : MonoBehaviour
{
    public float speedGroundMoving = 5.0f;
    public float speedplayer = 5.0f;
    public Transform snakeHead;
    public Transform ballPref;

    public List<Transform> snakeBalls = new List<Transform>();
    private List<Vector3> ballsPositions = new List<Vector3>();

    public float ballDiametr = 1.0f;

    public SmashScores SmashScores;

    void Update()
    {
        Movement(snakeHead);
        Generation();

    }

    private void Awake()
    {
        ballsPositions.Add(snakeHead.position);
    }

    private void Start()
    {
        AddBall();
        AddBall();
        AddBall();
    }

    private void OnCollisionStay (Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out SmashScores SmashScores))
        {
            speedGroundMoving = 0;
            speedplayer = 0f;
            Destroy(snakeBalls[0].gameObject);
            snakeBalls.Remove(snakeBalls[0]);
            ballsPositions.Remove(ballsPositions[0]);
            SmashScores.smashScores--;

            if (snakeBalls.Count == 0)
            {
                SceneManager.LoadScene(0);
            }
        }

        else if (!collision.gameObject.TryGetComponent(out SmashScores))
        {
            speedGroundMoving = 5f;
            speedplayer = 5f;
        }
    }

    public void Movement (Transform player)
    {
        player.transform.position = player.transform.position + new Vector3(0, 0, speedGroundMoving * Time.deltaTime);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.position = player.transform.position - new Vector3(speedplayer * Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.position = player.transform.position + new Vector3(speedplayer * Time.deltaTime, 0, 0);
        }
    }

    public void Generation ()
    {
        float distHeadBall = (snakeHead.position - ballsPositions[0]).magnitude;

        if (distHeadBall > ballDiametr)
        {
            Vector3 direction = (snakeHead.position - ballsPositions[0]).normalized;

            ballsPositions.Insert(0, ballsPositions[0] + direction * ballDiametr);
            ballsPositions.RemoveAt(ballsPositions.Count - 1);

            distHeadBall -= ballDiametr;
        }

        for (int i = 0; i < snakeBalls.Count; i++)
        {
            snakeBalls[i].position = Vector3.Lerp(ballsPositions[i + 1], ballsPositions[i], distHeadBall / ballDiametr);
        }
    }

    private void AddBall()
    {
        Transform ball = Instantiate(ballPref, ballsPositions[ballsPositions.Count - 1], Quaternion.identity, transform);
        snakeBalls.Add(ball);
        ballsPositions.Add(ball.position);
    }
}
