using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    
    public AudioSource musicSource;

    public float bpm = 120f;
    public float firstBeatOffset = 0f;
    public float bps = 2f;
    public float sbp = 0.5f;
    public float dspSongTime; //How many seconds have passed since the song started 
    public float songPosition; //Current song position, in seconds 
    public float songPositionInBeats; //Current song position, in beats 

   
    void Start()
    {
        bps = bpm / 60f;
        sbp = 60f/ bpm;
        dspSongTime = (float) AudioSettings.dspTime;
    }


    void Update()
    {
        //determine how many seconds since the song started 
        songPosition = (float) (AudioSettings.dspTime - dspSongTime - firstBeatOffset); 
        //determine how many beats since the song started 
        songPositionInBeats = songPosition * bps; 
    }
}
