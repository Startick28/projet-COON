using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DisapearRoutine());
    }

    public IEnumerator DisapearRoutine() {
        yield return new WaitForSeconds(0.2f);
        Destroy(this.gameObject);
    }
}
