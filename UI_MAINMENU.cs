using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_MAINMENU : MonoBehaviour
{
    [SerializeField]
    private AudioSource PressButton;


    public void Startgamebutton()
    {
        PressButton.Play();

        SceneManager.LoadScene(1);

    }

    public void Instabutton()
    {
        PressButton.Play();
        Application.OpenURL("https://www.instagram.com/magnusgamedev/");
    }

    public void FacebookButton()
    {
        PressButton.Play();

        Application.OpenURL("https://www.facebook.com/Magnus-Games-217122596404362");
    }

}
