using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLine : MonoBehaviour
{
    public Material material;
    public LineRenderer lineRenderer;
    public static float lineHeight = 3f;    
    
    public static float pulseLength = 0.2f;
    
    public IEnumerator Pulse() {
        float r;

        for (float i = 0f; i<pulseLength/4 ; i+= Time.deltaTime) {
            
            r = i/ (pulseLength/4);

            material.SetFloat("Laser_Alpha", Mathf.Lerp(0,1,r) );
            lineRenderer.widthMultiplier = Mathf.Lerp(0.1f,0.2f,r);

            yield return null;
        }
        material.SetFloat("Laser_Alpha", 1f);

        for (float i = 0f; i<3*pulseLength/4 ; i+= Time.deltaTime) {
            
            r = i / (3*pulseLength/4);

            material.SetFloat("Laser_Alpha", Mathf.Lerp(1,0,r*r) );
            lineRenderer.widthMultiplier = Mathf.Lerp(0.2f,0.1f,r);

            yield return null;
        }

        material.SetFloat("Laser_Alpha", 0f);
    }
    
}
