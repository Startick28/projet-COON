using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI chanson;
    private SongRepository.Song[] songList = { SongRepository.song1, SongRepository.song2, SongRepository.song3, SongRepository.song4 };

    private void Start()
    {
        chanson.text = songList[GameManager.instance.songNumber].name;
    }
    public void NextMusic()
    {
        if (GameManager.instance.songNumber < songList.Length -1)
        {
            GameManager.instance.songNumber++;
            chanson.text = songList[GameManager.instance.songNumber].name;
        }
        else
        {
            GameManager.instance.songNumber=0;
            chanson.text = songList[GameManager.instance.songNumber].name;
        }

    }
}
