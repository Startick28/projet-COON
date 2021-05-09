using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI chanson;
    public SongManager songManager;
    private void Start()
    {
        songManager.songNumber = 0;
    }
    public void NextMusic()
    {
        songManager.ChangeSong();
    }
}
