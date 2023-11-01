using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friends : MonoBehaviour
{
    public static int score = 0;
    public static int lives = 3;
    public static bool gameRunning = true;
    public static bool update = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Kuromi")
        {
            if (score % Generator.check == 0 && score != 0)
                update = true;
            Destroy(this.gameObject);
            score++;
        }

        if (col.gameObject.name == "Grass")
        {
            lives--;
            Destroy(this.gameObject);
            if (lives == 0)
                gameRunning = false;
        }
    }
}
