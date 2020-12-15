using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class spawn_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject Enemy;

    [SerializeField]
    private bool isgameover = false;

    void Start()
    {
        StartCoroutine("SpawnEnemy");
      
    }

    public void OnPlayerDeath()
    {
        isgameover = true ;
    }

    IEnumerator SpawnEnemy()

    {
        while (isgameover == false)
        {
        
            UnityEngine.Debug.Log("Enemy is Instantiated");

            Vector3 pos = new Vector3(4.0f, Random.Range(-2.5f, 2.5f), 0);
        
            Instantiate(Enemy, pos, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
       
        }
    }
}
