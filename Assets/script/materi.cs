using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class materi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Sound Manager") != null)
        {
            SoundManager.Instance.StopSound();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buttonmateri(string sceneName)
    {
        if (GameObject.Find("Sound Manager") != null)
        {
            SoundManager.Instance.PlaySound();
        }
        
        SceneManager.LoadScene(sceneName);
    }
}
