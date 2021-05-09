using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        updateScore();
    }


    public void GainPoints(int gain)
    {
        points += gain;
        updateScore();
    }
   
    private void updateScore()
    {
        score.text = "Score :\n" + points.ToString();
    }
}
