using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Quest : MonoBehaviour
{
    
    public GameObject feed_benar, feed_salah;


    public int[] randomJawabans;

    public ControlQuest controlQuest;
    int nomorSoal;
    public int gameRound; //nomor sesuai array 0=1 dimulai dari angka 1

    public GameObject panelHasil;

    public int[] randomsoals;

    [Header("point")]
    public Text pointText;
    public int point; //jika dia benar berapa point yg akan di tambah
    public static int totalPoint;
    public Text textPointGame;

    [Header("soal")]
    public Image imageSoal;
    public Button[] buttonjawabans;
    

    [Header("audio")]
    public AudioControl audioControl;

    [Header("Highscore")]
    public Highscore highscore;

    void Start()
    {
        totalPoint = 0;
        textPointGame.text = totalPoint.ToString();
        
        RandomNomorSoal();

        

        GenerateQuest();
    }

    void RandomNomorSoal()
    {
        for (int i = 0; i < randomsoals.Length; i++)
        {
             int a = randomsoals[i];
            int b = Random.Range(0, randomsoals.Length);
            randomsoals[i] = randomsoals[b];
            randomsoals[b] = a;
        }
    }

    void RandomNomorJawaban()
    {
        for (int i = 0; i < randomJawabans.Length; i++)
        {
            int a = randomJawabans[i];
            int b = Random.Range(0, randomJawabans.Length);
            randomJawabans[i] = randomJawabans[b];
            randomJawabans[b] = a;
        }
    }

    

    void GenerateQuest()
    {
        RandomNomorJawaban();

        imageSoal.sprite = controlQuest.soals[randomsoals[nomorSoal]].elementSoal.spriteSoal;

        for (int i = 0; i < buttonjawabans.Length; i++)
        {
            buttonjawabans[i].image.sprite = controlQuest.soals[randomsoals[nomorSoal]].elementSoal.spriteJawabans[randomJawabans[i]];   
        }
    }

    public void ButtonjawabanSoal()
    {
        
        Sprite spriteJawabans = EventSystem.current.currentSelectedGameObject.GetComponent<Button>().image.sprite;

        if (spriteJawabans.name == controlQuest.soals[randomsoals[nomorSoal]].elementSoal.spriteJawabans[controlQuest.soals[randomsoals[nomorSoal]].elementSoal.jawabnBenar].name )
        {
           
            Debug.Log("benar");
            audioControl.AudioBenar();
            feed_benar.SetActive(false);
            feed_benar.SetActive(true);
          
            totalPoint += point;
            nomorSoal++;
           
        }
        
        else
        {
            Debug.Log("salah");
            audioControl.AudioSalah();
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);
 
            nomorSoal++;

        }
        
        textPointGame.text = totalPoint.ToString();

        if (nomorSoal == gameRound  )
        {
            // panelHasil.transform.GetChild(1).GetComponent<Text>().text = "Anda Telah Mengerjakan Semua Soal";
            panelHasil.SetActive(true);

            pointText.text = "Point Akhir Anda :"+ totalPoint.ToString();

            //highscore
            highscore.UpdateHighscore();
        }

        
        

        else
        {
            GenerateQuest();
        }
        
        
       
    }

    public void ButtonNextSoal()
    {
        panelHasil.SetActive(false);

        nomorSoal++;

        GenerateQuest();
    }



}
