using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int type = 48;

    public bool hit = false;
    public bool missed = false;

    public Sprite type0;
    public Sprite type1;
    public Sprite type2;
    public Sprite type3;
    public Sprite type4;
    public Sprite type5;
    public Sprite type6;
    public Sprite type7;
    public Sprite type8;
    public Sprite type9;
    public Sprite type10;
    public Sprite type11;

    void Update()
    {
        transform.Translate(0, -SongManager.instance.bps * Time.deltaTime, 0);
        if (transform.position.y < 1.4f) Destroy(this.gameObject);

        if (this.type == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type0;
        }
        if (this.type == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type1;
        }
        if (this.type == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type2;
        }
        if (this.type == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type3;
        }
        if (this.type == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type4;
        }
        if (this.type == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type5;
        }
        if (this.type == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type6;
        }
        if (this.type == 7)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type7;
        }
        if (this.type == 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type8;
        }
        if (this.type == 9)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type9;
        }
        if (this.type == 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type10;
        }
        if (this.type == 11)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = type11;
        }
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
