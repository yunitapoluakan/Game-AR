using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlQuest : MonoBehaviour
{
    [System.Serializable]
    public class Soal
    {
        [System.Serializable]
        public class ElementSoal
        {

            public Sprite spriteSoal;//gambar


            public Sprite[] spriteJawabans;


            public int jawabnBenar;
        }

        public ElementSoal elementSoal;
    }

    public List<Soal> soals;

}
