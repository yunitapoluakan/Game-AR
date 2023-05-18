using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading_bar : MonoBehaviour
{

    float time, second;
    [SerializeField]
    public Image FillImage;

    void Start ()
    {
        second = 5;
        Invoke("LoadGame", 5f);
    }

    void update()
    {
        if (time < 5)
        {
            time += Time.deltaTime;
            FillImage.fillAmount = time / second;
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }


    // public Image loadingfill;

    // void Start() {
    //     StartCoroutine(Loading());
    // }

    // IEnumerator Loading() {
    //     AsyncOperation loading = SceneManager.LoadSceneAsync("Menu_utama");

    //     while (!loading.isDone) {
        
    //     // float progressValue = Mathf.Clamp01(operatio.prograss / 0.9f)
    //         loadingfill.fillAmount = loading.progress/0.9f;
    //         print(loading.progress);
    //         yield return null;
    //     }
    // }
}
