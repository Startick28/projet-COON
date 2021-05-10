using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    public static SongManager instance;
    
    public AudioSource musicSource;

    public SongRepository.Song song =  SongRepository.song1;

    private SongRepository.Song[] songList = { SongRepository.song1, SongRepository.song2 };

    public float bpm = 120f;
    public float firstBeatOffset = 0f;
    public float bps = 2f;
    public float sbp = 0.5f;
    public float dspSongTime; //How many seconds have passed since the song started 
    public float songPosition; //Current song position, in seconds 
    public float songPositionInBeats; //Current song position, in beats 
    private float beatCounter = 0f;

    public int currentChunk = 1; //Current group of notes that has been loaded
    public int songArrayIndice = 0;

    public Monster monsterPrefab;
    public GameObject ennemiesContainer;

    public Transform[] fireTransforms = new Transform[5];
    public Material[] fireMaterials = new Material[5];

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
        song = songList[GameManager.instance.songNumber];
        musicSource = GetComponent<AudioSource>();

        musicSource.clip = GameManager.instance.clips[GameManager.instance.songNumber];
        bpm = song.bpm;
        firstBeatOffset = song.offset;

        bps = bpm / 60f;
        sbp = 60f/ bpm;

        dspSongTime = (float) AudioSettings.dspTime;
        musicSource.Play();
        
        currentChunk = -1;
        beatCounter = 0;

    }


    void Update()
    {
        songPosition = (float) (AudioSettings.dspTime - dspSongTime - firstBeatOffset); 
        songPositionInBeats = songPosition * bps; 

        if (songPosition >= 4 * currentChunk + 2) {

            StartCoroutine(LoadChunk(currentChunk));
            currentChunk++;
        }

        if (songPositionInBeats >= beatCounter) {
            beatCounter++;
            StartCoroutine(FirePulse());
        }
    }


    public IEnumerator LoadChunk(int chunk) {
        Vector3 pos;
        foreach ( float[] noteArray in song.notes ) {
            if (noteArray[0] >= 4*(chunk+1)*bps && noteArray[0] < 4*(chunk+2)*bps) {
                for (int i = 1 ; i < noteArray.Length ; i++) {
                    //determine how many seconds since the song started 
                    songPosition = (float) (AudioSettings.dspTime - dspSongTime - firstBeatOffset); 
                    //determine how many beats since the song started 
                    songPositionInBeats = songPosition * bps; 
                    pos = new Vector3( KeyManager.noteToPos( (int) (noteArray[i]+21)).x , 3.05f + (noteArray[0] - songPositionInBeats)*song.speedMultiplier ,0);
                    

                    MonsterFactory._instance.GetMonster(pos,((int) noteArray[i]+21));



                    //tmp = Instantiate(monsterPrefab, pos ,Quaternion.identity);
                    //tmp.transform.SetParent(ennemiesContainer.transform);
                    //tmp.type = (int) noteArray[i]+21;
                    //tmp.gameObject.GetComponent<MeshRenderer>().material = KeyManager.instance.materials[(((int) noteArray[i]+21)-36)%12];
                    yield return null;
                }
            }
        }
        yield return null;
    }


    public IEnumerator FirePulse() {
        float r;
        float pulseLength = 0.2f;
        Vector3 originalScale1 = fireTransforms[0].localScale;
        Vector3 originalScale2 = fireTransforms[3].localScale;
        Vector3 finalScale1 = new Vector3(originalScale1.x + 0.5f, originalScale1.y + 0.1f, originalScale1.z);
        Vector3 finalScale2 = new Vector3(originalScale2.x + 0.5f, originalScale2.y + 0.1f, originalScale2.z);
        Vector3 tmp1 = originalScale1;
        Vector3 tmp2 = originalScale2;

        for (float i = 0f; i<pulseLength/4 ; i+= Time.deltaTime) {
            
            r = i/ (pulseLength/4);

            tmp1 = Vector3.Lerp(originalScale1,finalScale1,r);
            tmp2 = Vector3.Lerp(originalScale2,finalScale2,r);
            
            fireTransforms[0].localScale = tmp1;
            fireTransforms[1].localScale = tmp1;
            fireTransforms[2].localScale = tmp1;

            fireTransforms[3].localScale = tmp2;
            fireTransforms[4].localScale = tmp2;


            yield return null;
        }
        fireTransforms[0].localScale = finalScale1;
        fireTransforms[1].localScale = finalScale1;
        fireTransforms[2].localScale = finalScale1;

        fireTransforms[3].localScale = finalScale2;
        fireTransforms[4].localScale = finalScale2;

        for (float i = 0f; i<3*pulseLength/4 ; i+= Time.deltaTime) {
            
            r = i / (3*pulseLength/4);

            tmp1 = Vector3.Lerp(finalScale1,originalScale1,r);
            tmp2 = Vector3.Lerp(finalScale2,originalScale2,r);

            fireTransforms[0].localScale = tmp1;
            fireTransforms[1].localScale = tmp1;
            fireTransforms[2].localScale = tmp1;

            fireTransforms[3].localScale = tmp2;
            fireTransforms[4].localScale = tmp2;

            yield return null;
        }

        fireTransforms[0].localScale = originalScale1;
        fireTransforms[1].localScale = originalScale1;
        fireTransforms[2].localScale = originalScale1;

        fireTransforms[3].localScale = originalScale2;
        fireTransforms[4].localScale = originalScale2;

    }


    
    public IEnumerator FireColorPulse() {
        float r;
        float pulseLength = 0.2f;

        for (float i = 0f; i<pulseLength/4 ; i+= Time.deltaTime) {
            
            r = i/ (pulseLength/4);

            for (int j = 0; j<5; j++) {
                fireMaterials[j].SetFloat("_Hue", Mathf.Lerp(0f,0.8f,r) );
            }

            //fireMat1.SetFloat("_Hue", Mathf.Lerp(0f,0.8f,r) );
            //fireMat2.SetFloat("_Hue", Mathf.Lerp(0f,0.8f,r) );

            yield return null;
        }

        for (int j = 0; j<5; j++) {
                fireMaterials[j].SetFloat("_Hue", 0.8f );
        }
        //fireMat1.SetFloat("_Hue",0.8f );
        //fireMat2.SetFloat("_Hue",0.8f );
        /*
        for (float i = 0f; i<3*pulseLength/4 ; i+= Time.deltaTime) {
            
            r = i / (3*pulseLength/4);

            fireMat1.SetFloat("_Hue", Mathf.Lerp(80,0,r*r) );
            fireMat2.SetFloat("_Hue", Mathf.Lerp(80,0,r*r) );

            yield return null;
        }

        fireMat1.SetFloat("_Hue",0 );
        fireMat2.SetFloat("_Hue",0 );
        */
    }

}
