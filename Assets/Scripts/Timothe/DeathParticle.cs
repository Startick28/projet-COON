using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathParticle : MonoBehaviour
{
    public ParticleSystem particules;

    void Start()
    {
        StartCoroutine(DeathCoroutine());
    }


    public IEnumerator DeathCoroutine(){
        particules.Emit(5);
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }

}
