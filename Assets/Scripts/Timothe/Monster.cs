using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int type = 48;

    public bool hit = false;
    public bool missed = false;
    public PlayerHealth vie;
    public ScoreManager score;



    void Update()
    {
        transform.Translate(0, -SongManager.instance.bps * Time.deltaTime * SongManager.instance.song.speedMultiplier, 0);
        if (transform.position.y < 1.4f) {
            MonsterFactory.EndMonster(this);
        }

    }

    public void Hit()
    {
        float Y = transform.position.y;
        if (Y >= BasicLine.lineHeight - 0.04 && Y <= BasicLine.lineHeight + 0.04)
        {
            Debug.Log("PERFECT");
            vie.Heal(15);
            score.GainPoints(300);
            MonsterFactory.EndMonster(this);
        }
        else if ((Y >= BasicLine.lineHeight - 0.07 && Y <= BasicLine.lineHeight - 0.04) || (Y >= BasicLine.lineHeight + 0.04 && Y <= BasicLine.lineHeight + 0.07))
        {
            Debug.Log("GOOD");
            vie.Heal(10);
            score.GainPoints(100);
            MonsterFactory.EndMonster(this);
        }
        else if ((Y >= BasicLine.lineHeight - 0.1 && Y <= BasicLine.lineHeight - 0.07) || (Y >= BasicLine.lineHeight + 0.07 && Y <= BasicLine.lineHeight + 1))
        {
            Debug.Log("OK");
            vie.Heal(15);
            score.GainPoints(50);
            MonsterFactory.EndMonster(this);
        }
    }

}
