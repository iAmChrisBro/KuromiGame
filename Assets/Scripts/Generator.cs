using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Generator : MonoBehaviour
{
    public float timer;
    public GameObject[] gm;
    public GameObject gameOverUI;

    public float multiplier;
    public static int check = 10;
    private int waves = 1;
    private TMP_Text waveCount;

    public float min, max;

   void Start()
    {
        Time.timeScale = 1;
        waveCount = GameObject.Find("Wave Count").GetComponent<TMP_Text>();
        gameOverUI.SetActive(false);
        Invoke("StartGenerator", 3);
        
    }

    void Update()
    {
        if(!Friends.gameRunning)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (Friends.update)
        {
            WaveUpdate();
            Friends.update = false;
        }
    }

    private void StartGenerator()
    {
        StartCoroutine(FriendSpawn());
    }

    IEnumerator FriendSpawn()
    {
        while (Friends.gameRunning)
        {
            
            float wanted = Random.Range(min, max);
            Vector3 position = new Vector3(wanted, transform.position.y);
            GameObject friend = Instantiate(gm[Random.Range(0, gm.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(timer);
        }
    }

    private void WaveUpdate()
    {
        waves++;
        waveCount.text = waves.ToString();
        timer -= multiplier;
        if (timer <= 1)
            timer = 1f;
    }

}
