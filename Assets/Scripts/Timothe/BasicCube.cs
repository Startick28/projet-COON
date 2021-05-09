using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCube : MonoBehaviour
{
    public int type = 48;

    public bool hit = false;
    public bool missed = false;
    
    void Update()
    {
        transform.Translate(0,-SongManager.instance.bps*Time.deltaTime,0);
        if (transform.position.y < 0) Destroy(this.gameObject);

        if (hit && !missed) {
            foreach( int i in KeyManager.instance.lineTypes) {
               if (i == type) {
                   Destroy(this.gameObject);
               }
           }
        }
        
    }

}
