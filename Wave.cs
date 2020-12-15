using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public bool gameover = false;

    void Start()
    {
        transform.position = new Vector3(0f, -7.90f, 0);
    }

    public void Update()

    {
        if (gameover == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 0.50f);
        }

        if (transform.position.x < -13.11f)
        {
            transform.position = new Vector3(5.75f, -7.90f, 0);

        }
    }

    public void GameOver()
    {
        gameover = true;
    }
}
