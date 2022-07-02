using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject[] nivele;
    public GameObject ResetScreen,EndScreen; 
    int LevelulCurent;

    public void wrongAnswer()
    {
        AudioScript.var.pornesteEfecteleDeSunet(1);
        ResetScreen.SetActive(true);
    }

    public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void correctAnswer()
    {
        if(LevelulCurent + 1 != nivele.Length)
        {
            nivele[LevelulCurent].SetActive(false);

            LevelulCurent++;
            nivele[LevelulCurent].SetActive(true);
        }
        else
        {
            AudioScript.var.pornesteEfecteleDeSunet(0);
            EndScreen.SetActive(true);
            nivele[LevelulCurent].SetActive(false);
        }
    }


}
