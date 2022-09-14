using UnityEngine;
using TMPro;

public class ScoreCounterBlock : MonoBehaviour
{
    private TMP_Text textScore;
    public SmashScores smashScores;

    private void Awake()
    {
        textScore = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = smashScores.smashScores.ToString();
    }
}
