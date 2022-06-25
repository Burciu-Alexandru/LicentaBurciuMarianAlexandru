using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject[] Levels;
    public GameObject ResetScreen,EndScreen; 

    int currentLevel;


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
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
        else
        {
            AudioScript.var.pornesteEfecteleDeSunet(0);
            EndScreen.SetActive(true);
            Levels[currentLevel].SetActive(false);
        }
    }


}
