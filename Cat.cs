using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    [SerializeField]
    private float force = 5f;

    [SerializeField]
    private spawn_manager spawn_manager;

    [SerializeField]
    private UI_Manager UI_Manager;

    [SerializeField]
    private bool isgameover = false ;

    [SerializeField]
    private Wave wave;

    [SerializeField]
    private AudioSource collideaudio;

    void Start()
    {
        Debug.Log("Game Has Started");
        
        spawn_manager = GameObject.Find("spawn_manager").GetComponent<spawn_manager>();

        wave = GameObject.Find("wave").GetComponent<Wave>();

        UI_Manager = GameObject.Find("Canvas").GetComponent<UI_Manager>();

        if (spawn_manager == null)
        {
            Debug.LogError("Spawn Manager Not Found");
        }


        if (UI_Manager == null)
        {
            Debug.LogError("UI Canvas Not Found");
        }

       
    }

    void Update()
    {
        if ( transform.position.y >= 4.60f)
        {
            transform.position = new Vector3(transform.position.x , 4.50f,0);
            spawn_manager.OnPlayerDeath();
            UI_Manager.Ongameover();
            isgameover = true;
            wave.GameOver();
            UI_Manager.CheckForBestScore();

        } 
        
            if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 )
        {
            if (isgameover == false)

            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * force;
            }
        }

    }

   void OnCollisionEnter2D(Collision2D Cobject)
    {
        if(Cobject.gameObject.tag == "Enemy" )
        {
            Debug.Log("Enemy Collided");
            collideaudio.Play();
            spawn_manager.OnPlayerDeath();
            UI_Manager.Ongameover();
            isgameover = true;
            wave.GameOver();
            Destroy(Cobject.gameObject);
            UI_Manager.CheckForBestScore();
        }

        if (Cobject.gameObject.tag == "Wave")

        {
            Debug.Log("Wave Collided");
            collideaudio.Play();
            spawn_manager.OnPlayerDeath();
            UI_Manager.Ongameover();
            isgameover = true;
            wave.GameOver();
            UI_Manager.CheckForBestScore();

        }
    }
    
    
}
