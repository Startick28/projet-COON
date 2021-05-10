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

    void Start()
    {
        score = GameObject.Find("Score").GetComponent<ScoreManager>();
        vie = GameObject.Find("Life").GetComponent<PlayerHealth>();
    }

    void Update()
    {
        transform.Translate(0, -SongManager.instance.bps * Time.deltaTime * SongManager.instance.song.speedMultiplier, 0);
        if (transform.position.y < 1.4f) {
            GameManager.instance.sfxSource.PlayOneShot(GameManager.instance.playerHit,0.4f);
            SongManager.instance.FiyahPulse();
            MonsterFactory.EndMonster(this);
            vie.TakeDamage(5);
        }

    }

    public void Hit()
    {

        float Y = transform.position.y;
        if (Y >= BasicLine.lineHeight - 0.04 && Y <= BasicLine.lineHeight + 0.04)
        {
            GameManager.instance.sfxSource.PlayOneShot(GameManager.instance.monsterHit,0.5f);
            Debug.Log("PERFECT");
            vie.Heal(15);
            score.GainPoints(300);
            MonsterFactory.EndMonster(this);
        }
        else if ((Y >= BasicLine.lineHeight - 0.07 && Y <= BasicLine.lineHeight - 0.04) || (Y >= BasicLine.lineHeight + 0.04 && Y <= BasicLine.lineHeight + 0.07))
        {
            GameManager.instance.sfxSource.PlayOneShot(GameManager.instance.monsterHit,0.5f);
            Debug.Log("GOOD");
            vie.Heal(10);
            score.GainPoints(100);
            MonsterFactory.EndMonster(this);
        }
        else if ((Y >= BasicLine.lineHeight - 0.1 && Y <= BasicLine.lineHeight - 0.07) || (Y >= BasicLine.lineHeight + 0.07 && Y <= BasicLine.lineHeight + 1))
        {
            GameManager.instance.sfxSource.PlayOneShot(GameManager.instance.monsterHit,0.3f);
            Debug.Log("OK");
            vie.Heal(5);
            score.GainPoints(50);
            MonsterFactory.EndMonster(this);
        }
    }

}
