using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fiyah : MonoBehaviour
{
    public Material material;
    public static float lineHeight = 3f;    
    
    public static float pulseLength = 0.2f;
    
    public IEnumerator Pulse() {
        float r;

        for (float i = 0f; i<pulseLength/4 ; i+= Time.deltaTime) {
            
            r = i/ (pulseLength/4);

            material.SetFloat("Hue", Mathf.Lerp(0f,0.25f,r) );

            yield return null;
        }
        material.SetFloat("Hue", 0.25f);

        for (float i = 0f; i<3*pulseLength/4 ; i+= Time.deltaTime) {
            
            r = i / (3*pulseLength/4);

            material.SetFloat("Hue", Mathf.Lerp(0.25f,0f,r*r*r) );

            yield return null;
        }

        material.SetFloat("Hue", 0f);
    }
}
