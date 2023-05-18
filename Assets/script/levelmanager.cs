using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour
{
    public static int indexGame;

    public void btn_gamedarat(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        
        indexGame = 0;
    }

    public void btn_gameair(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        indexGame = 1;
    }

    public void btn_gamehutan(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        indexGame = 2;
    }

    public void btn_gameterbang(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        indexGame = 3;   
    }

    public void LoadToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void btn_keluargame()
    {
        Application.Quit();
    }

    public void btn_unduhmarker()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1IDmL-qfSioKsl0HLafQLBWXuyO8VfxEl?usp=share_link");
    }



    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume",volume);
    }

    
}
