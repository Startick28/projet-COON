using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int type = 48;

    public bool hit = false;
    public bool missed = false;

    void Update()
    {
        transform.Translate(0, -SongManager.instance.bps * Time.deltaTime, 0);
        if (transform.position.y < 1.4f) Destroy(this.gameObject);
    }

    public void Hit()
    {
        float Y = transform.position.y;
        if (Y >= BasicLine.lineHeight - 0.04 && Y <= BasicLine.lineHeight + 0.04)
        {
            Debug.Log("PERFECT");
            Destroy(this.gameObject);
        }
        else if ((Y >= BasicLine.lineHeight - 0.07 && Y <= BasicLine.lineHeight - 0.04) || (Y >= BasicLine.lineHeight + 0.04 && Y <= BasicLine.lineHeight + 0.07))
        {
            Debug.Log("GOOD");
            Destroy(this.gameObject);
        }
        else if ((Y >= BasicLine.lineHeight - 0.1 && Y <= BasicLine.lineHeight - 0.07) || (Y >= BasicLine.lineHeight + 0.07 && Y <= BasicLine.lineHeight + 1))
        {
            Debug.Log("OK");
            Destroy(this.gameObject);
        }
    }

}
