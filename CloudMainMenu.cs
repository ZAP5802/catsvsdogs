using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMainMenu : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 0.50f);
       
        if(transform.position.x < -5.3f)
        {
            transform.position = new Vector3( 5.20f , transform.position.y,0);
        }
    }
}
