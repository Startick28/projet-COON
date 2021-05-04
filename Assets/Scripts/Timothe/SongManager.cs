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

    public int currentChunk = 0; //Current group of notes that has been loaded
    public int songArrayIndice = 0;

   
    void Start()
    {
        musicSource = GetComponent<AudioSource>();

        musicSource.clip = GameManager.instance.clip;

        bps = bpm / 60f;
        sbp = 60f/ bpm;
        dspSongTime = (float) AudioSettings.dspTime;

        // TODO
        // Load the first chunk of the song

        musicSource.Play();
    }


    void Update()
    {
        //determine how many seconds since the song started 
        songPosition = (float) (AudioSettings.dspTime - dspSongTime - firstBeatOffset); 
        //determine how many beats since the song started 
        songPositionInBeats = songPosition * bps; 

        if (songPositionInBeats >= 8 * currentChunk + 4) {
            // TODO
            // Load toutes les notes entre 4 * currentChunk et 4 * (currentChunk + 1)
        }


    }
}
