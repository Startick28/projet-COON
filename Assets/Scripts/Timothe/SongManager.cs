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
    public GameObject ennemiesContainer;

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

        dspSongTime = (float) AudioSettings.dspTime;
        musicSource.Play();
        
        currentChunk = -1;

    }


    void Update()
    {
        songPosition = (float) (AudioSettings.dspTime - dspSongTime - firstBeatOffset); 
        songPositionInBeats = songPosition * bps; 

        if (songPosition >= 4 * currentChunk + 2) {

            StartCoroutine(LoadChunk(currentChunk));
            currentChunk++;
        }
    }


    public IEnumerator LoadChunk(int chunk) {
        BasicCube tmp;
        Vector3 pos;
        foreach ( float[] noteArray in song.notes ) {
            if (noteArray[0] >= 4*(chunk+1)*bps && noteArray[0] < 4*(chunk+2)*bps) {
                for (int i = 1 ; i < noteArray.Length ; i++) {
                    //determine how many seconds since the song started 
                    songPosition = (float) (AudioSettings.dspTime - dspSongTime - firstBeatOffset); 
                    //determine how many beats since the song started 
                    songPositionInBeats = songPosition * bps; 
                    pos = new Vector3( KeyManager.noteToPos( (int) (noteArray[i]+21)).x , 3.05f + noteArray[0] - songPositionInBeats ,0);
                    tmp = Instantiate(cubePrefab, pos ,Quaternion.identity);
                    tmp.transform.SetParent(ennemiesContainer.transform);
                    tmp.type = (int) noteArray[i]+21;
                    tmp.gameObject.GetComponent<MeshRenderer>().material = KeyManager.instance.materials[(((int) noteArray[i]+21)-36)%12];
                    yield return null;
                }
            }
        }
        yield return null;
    }

}
