using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trackable : DefaultTrackableEventHandler
{
    public AudioSource suara;

    void Awake()
    {
        suara = GetComponent<AudioSource>();
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        suara.Play();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        suara.Stop();
    }
}
