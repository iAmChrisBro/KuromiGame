using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeSong : MonoBehaviour
{
    private AudioSource src;
    void Start()
    {
        src = this.GetComponent<AudioSource>();
        src.Play();
    }
}