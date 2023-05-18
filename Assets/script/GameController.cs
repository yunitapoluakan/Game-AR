using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject PanelInfo;

    public bool show = false;

    public void ShowHidenInfo()
    {
        if (!show)
        {
            PanelInfo.SetActive(true);
            show = true;
        }
        else
        {
            PanelInfo.SetActive(false);
            show = false;
        }
    }
}
