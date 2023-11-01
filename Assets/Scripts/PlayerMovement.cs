using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Animator animate;

    void Start()
    {
        animate = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float jumpHeight = Mathf.Clamp(Input.GetAxis("Jump"),0f,0.5f);

        float x = Mathf.Clamp(h, -1f, 1f);

        if (x > 0.001 || x < -0.001)
        {
            animate.SetBool("Idle", false);
        }
        else
            animate.SetBool("Idle", true);

        if (jumpHeight > 0)
        {
            animate.SetBool("Jump", true);
        }
        else
        {
            animate.SetBool("Jump", false);
        }

        animate.SetFloat("Speed", x);

        Vector3 movement = new Vector3(h, jumpHeight, 0);

        movement = movement.normalized * speed * Time.deltaTime;

        transform.position += movement;
    }
}
