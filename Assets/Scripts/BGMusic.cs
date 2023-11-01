using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    private AudioSource music;
    private int musicIndex;
    public AudioClip[] songs;

    void Start()
    {
        music = this.GetComponent<AudioSource>();
        musicIndex = Random.Range(0, 2);
        music.clip = songs[musicIndex];
        music.Play();
    }

    void Update()
    {

        if (!music.isPlaying)
        {
            musicIndex++;
            if (musicIndex > 2)
                musicIndex = 0;
            music.clip = songs[musicIndex];
            music.Play();
        }
    }
}
