using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public TextMeshPro vie;

    public void SetMaxHealth(int health)
    {
        vie.text = health.ToString();
    }

    public void SetHealth(int health)
    {
        vie.text = health.ToString();
    }
}
