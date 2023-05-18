using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource audioDefault;
    public AudioClip audioClipBenar, audioClipSalah;

    // public Image imageDefault;
    // public Sprite feed_benar, feed_salah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AudioBenar()
    {
        audioDefault.PlayOneShot(audioClipBenar);
    }
    
    public void AudioSalah()
    {
        audioDefault.PlayOneShot(audioClipSalah);
    }

    // public void FeedBenar()
    // {

    // }
}
