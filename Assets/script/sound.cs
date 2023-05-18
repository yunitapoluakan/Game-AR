using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
   public AudioSource PlaySound;

    private bool muted = true;

    //ini baru da tambah
    public void playsound()
    {
        
        PlaySound.Play();

    }


    public void playmutesound()
    {       
        // PlaySound.Play;

        if (muted == true)
        {
            muted = false;
            PlaySound.mute = false;
        }
        else
        {
            muted = true;
            PlaySound.mute = true;
        }

    }

    // private bool muted = false;

    // public void playmutesound()
    // {       
    //     // PlaySound.Play;
    //     if (muted == false)
    //     {
    //         muted = true;
    //         PlaySound.mute = true;
    //     }
    //     else
    //     {
    //         muted = false;
    //         PlaySound.mute = false;
    //     }
    // }
}
