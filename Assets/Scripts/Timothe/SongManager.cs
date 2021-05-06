using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    public static SongManager instance;
    
    public AudioSource musicSource;

    public SongRepository.Song song = SongRepository.song1;

    public float bpm = 120f;
    public float firstBeatOffset = 0f;
    public float bps = 2f;
    public float sbp = 0.5f;
    public float dspSongTime; //How many seconds have passed since the song started 
    public float songPosition; //Current song position, in seconds 
    public float songPositionInBeats; //Current song position, in beats 

    public int currentChunk = 1; //Current group of notes that has been loaded
    public int songArrayIndice = 0;

    public BasicCube cubePrefab;

   public void Awake()
    {
        if(instance)
        {
            Debug.Log("Il y a déjà une instance de SongManager " + name);
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        musicSource = GetComponent<AudioSource>();

        musicSource.clip = GameManager.instance.clip;
        bpm = song.bpm;
        firstBeatOffset = song.offset;

        bps = bpm / 60f;
        sbp = 60f/ bpm;

        StartCoroutine(StartMusic());
        
    }


    void Update()
    {
        //determine how many seconds since the song started 
        songPosition = (float) (AudioSettings.dspTime - dspSongTime - firstBeatOffset); 
        //determine how many beats since the song started 
        songPositionInBeats = songPosition * bps; 

        BasicCube tmp;
        Vector3 pos;

        if (songPosition >= 4 *(currentChunk+1)) {
            foreach ( float[] noteArray in song.notes ) {
                if (noteArray[0] >= 4*(currentChunk+2)*bps && noteArray[0] < 4*(currentChunk+3)*bps) {
                    for (int i = 1 ; i < noteArray.Length ; i++) {
                        pos = new Vector3( KeyManager.noteToPos( (int) (noteArray[i]+21)).x , 3 + noteArray[0] + 1 - songPositionInBeats ,0);
                        tmp = Instantiate(cubePrefab, pos ,Quaternion.identity);
                    }
                }
            }
            currentChunk++;
        }
    }

    public IEnumerator StartMusic() {
        BasicCube tmp;
        Vector3 pos;
        foreach ( float[] noteArray in song.notes ) {
            if (noteArray[0] < 8*bps) {
                for (int i = 1 ; i < noteArray.Length ; i++) {
                    pos = new Vector3( KeyManager.noteToPos( (int) noteArray[i]+21).x , 3 + 3 * bps + noteArray[0] + firstBeatOffset ,0);
                    tmp = Instantiate(cubePrefab, pos ,Quaternion.identity);
                }
            }
        }
        yield return new WaitForSeconds(3);
        currentChunk = 0;
        dspSongTime = (float) AudioSettings.dspTime;
        musicSource.Play();
    }

}
