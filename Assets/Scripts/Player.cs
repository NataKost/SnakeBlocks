using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public NewGen NewGen;
    public SmashScores SmashScores;

    private void OnCollisionEnter(Collision collision)
    {
            NewGen.snakeBalls.Remove(NewGen.snakeBalls[NewGen.snakeBalls.Count - 1]);
            SmashScores.smashScores--;
    }
}
