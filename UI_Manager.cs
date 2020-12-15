using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private bool isgameover = false;

    [SerializeField]
    private int currentscore = 0 ;

    private int bestscore;

    [SerializeField]
    private Text Currentscore;

    [SerializeField]
    private Text BestScore_txt;


    [SerializeField]
    private AudioSource collideaudio;


    [SerializeField]
    private GameObject gameoverpanel;

    [SerializeField]
    private GameObject HomeButton;

    [SerializeField]
    private GameObject retryButton;

    [SerializeField]
    private Text Gameover;

    public  void  Ongameover()
    {
        isgameover = true;
    }

    void Start()
    {
        bestscore = PlayerPrefs.GetInt("bestscore", 0 );
        BestScore_txt.text = "Best Score : " + bestscore;

    }
    void Update()
    {
        if (isgameover == true)
        {
            Gameover.gameObject.SetActive(true);
            HomeButton.gameObject.SetActive(true);
            retryButton.gameObject.SetActive(true);
            gameoverpanel.gameObject.SetActive(true);
     
        }
    }

    public void Score()
    {
        if (isgameover == false)

        { 
            currentscore++;

            Currentscore.text = "Score : " + currentscore;

        }   
        
    }
        public void CheckForBestScore()
    {
        if (bestscore <  currentscore)
        {
            bestscore = currentscore;

            PlayerPrefs.SetInt("bestscore", bestscore);

            BestScore_txt.text = "Best Score : " + bestscore;
        }
    }

    public void Onbuttonhome()
    {
        collideaudio.Play();
        SceneManager.LoadScene(0);

    }

    public void RetryButton()
    {
        collideaudio.Play();
        SceneManager.LoadScene(1);
    }

}
