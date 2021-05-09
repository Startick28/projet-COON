﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    public AudioClip clip;

    public int songNumber= 0;

    public void Awake()
    {
        if(instance)
        {
            Debug.Log("Il y a déjà une instance de GameManager " + name);
            Destroy(this);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        Application.targetFrameRate = 60;


    }
}
