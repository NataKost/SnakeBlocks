using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashScores : MonoBehaviour
{
    public int smashScores;

    private void Start()
    {
        smashScores = Random.Range(1, 5);
    }
}
