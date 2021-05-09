using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLine : MonoBehaviour
{
    
   void OnTriggerEnter(Collider col) {
       if (col.CompareTag("BaseBlock")) {
           col.gameObject.GetComponent<BasicCube>().hit = true;
       }
   }

    void OnTriggerExit(Collider col) {
       if (col.CompareTag("BaseBlock")) {
           col.gameObject.GetComponent<BasicCube>().missed = true;
       }
   }

    
}
