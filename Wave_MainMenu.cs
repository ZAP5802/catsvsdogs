using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_MainMenu : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 0.50f);

        if (transform.position.x < -8.35f)
        {
            transform.position = new Vector3(0.25f, transform.position.y, 0);
        }
    }
}
