using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private float speed = 1.50f;

    [SerializeField]
    private UI_Manager UI_manager;

    
    void Start()
    {

        UI_manager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
        

        transform.position = new Vector3(4.0f, Random.Range(-2.5f, 2.5f), 0);
    
    }
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < -2.755f) 

        {
            UI_manager.Score();
            Destroy(this.gameObject);
        }
   
    }

}
