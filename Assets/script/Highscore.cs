using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    // public text textTotalScore; 
    // public int totalScoreGame; // total point akhir

    public string[] namePlayer;
    int newIndexNamePlayer;
    public int[] scorePlayer;

    //ui
    public InputField inputFieldName;
    public Text textNomerRank;
    public Button buttonSave;

    public Text[] textNamePlayer;
    public Text[] textScorePlayer;
   
    // Start is called before the first frame update
    void Start()
    {
        

        LoadHighscore();
        
        // UpdateHighscore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NamePlayerDetect()
    {
        if (inputFieldName.text.Length > 0)
        {
            buttonSave.interactable = true;
        }
        else
        {
            buttonSave.interactable = false;
        }
    }

    void LoadHighscore()
    {
        for (int i = 0; i < namePlayer.Length; i++)
        {
            namePlayer[i] = PlayerPrefs.GetString(levelmanager.indexGame + "NamePlayer" + i, "Kosong" );
            textNamePlayer[i].text = namePlayer[i];

            scorePlayer[i] = PlayerPrefs.GetInt(levelmanager.indexGame + "ScorePlayer" + i, 0);
            textScorePlayer[i].text = scorePlayer[i].ToString();
        }
    }

    public void UpdateHighscore()
    {
        int newIndexHighscore = -1;

        for (int i = 0; i < scorePlayer.Length; i++)
        {
            if (Quest.totalPoint >= scorePlayer[i])
            {
                newIndexHighscore = i;

                break;
            }
            
        }
        
        if (newIndexHighscore >= 0)
        {
            for (int i = scorePlayer.Length - 1; i > newIndexHighscore; i--)
            {
                namePlayer[i] = namePlayer[i - 1];
                textNamePlayer[i].text = namePlayer[i];

                scorePlayer[i] = scorePlayer[i - 1];
                textScorePlayer[i].text = scorePlayer[i].ToString();
                
            }
            scorePlayer [newIndexHighscore] = Quest.totalPoint;
            newIndexNamePlayer = newIndexHighscore;

            textNomerRank.text = (newIndexHighscore +  1).ToString();

            textNamePlayer[newIndexNamePlayer].text = "";
            textScorePlayer[newIndexHighscore].text = "";
        }

        else
        {
            inputFieldName.interactable = false;
            buttonSave.interactable = false;
        }
    }
    
    public void ButtonSave()
    {
        namePlayer[newIndexNamePlayer] = inputFieldName.text;

        textNamePlayer[newIndexNamePlayer].text = namePlayer[newIndexNamePlayer];
        textScorePlayer[newIndexNamePlayer].text = scorePlayer[newIndexNamePlayer].ToString();
        
        for (int i = 0; i < namePlayer.Length; i++)
        {
            PlayerPrefs.SetString(levelmanager.indexGame + "NamePlayer" +i, namePlayer[i]);

            PlayerPrefs.SetInt(levelmanager.indexGame + "ScorePlayer" +i, scorePlayer[i]);
        }

        buttonSave.interactable = false;
        inputFieldName.interactable = false;

        
    }

    public void Btn_resetskor()
    {
        PlayerPrefs.DeleteAll();

       LoadHighscore();
    }
}
