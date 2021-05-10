using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    public AudioClip[] clips = new AudioClip[2];

    public AudioSource sfxSource;
    public AudioClip monsterHit;
    public AudioClip playerHit;
    public AudioClip menuSound;
    public AudioClip menuSelect;


    public int songNumber= 0;

    public void Awake()
    {
        if(instance)
        {
            Debug.Log("Il y a déjà une instance de GameManager " + name);
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        Application.targetFrameRate = 60;


    }
}
