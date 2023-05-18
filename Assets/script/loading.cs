using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    float time, second;
    [SerializeField]
    public Image loadingfill;

    void Start ()
    {
        second = 3;
        Invoke("LoadGame", 3f);
    }

    void update()
    {
        if (time < 3)
        {
            time += Time.deltaTime;
            loadingfill.fillAmount = time / second;
           
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

}
