using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public SongRepository.Song song = SongRepository.song1;

    private void Start()
    {
        gameObject.GetComponent<TextMeshPro>().text = song.ToString();
    }
    public void NextMusic()
    {
        gameObject.GetComponent<TextMeshPro>().text = song.ToString();
    }
}
