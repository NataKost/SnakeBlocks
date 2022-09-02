using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    public GameObject[] levelPref;
    public int minParts;
    public int maxParts;
    public float distance;
    public Transform Finish;
    public Transform Start;

    private void Awake()
    {
        int randomNumberOfParts = Random.Range(minParts, maxParts + 1);

        for (int i = 0; i < randomNumberOfParts; i++)
        {
            int chosenPref = Random.Range(0, levelPref.Length);

            GameObject part = Instantiate(levelPref[chosenPref], transform);

            if (i > 0)
            {
                part.transform.localPosition = new Vector3(Start.localPosition.x, Start.localPosition.y, distance * i);
            }

            if (i == 0)
            {
                part.transform.localPosition = new Vector3(Start.localPosition.x, Start.localPosition.y, distance);
            }

            part.transform.localRotation = Quaternion.Euler(0, - 90, 0);
        }

        Finish.localPosition = new Vector3(Start.localPosition.x, Start.localPosition.y, distance * randomNumberOfParts);
    }
}
