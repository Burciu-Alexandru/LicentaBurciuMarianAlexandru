using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
   public void PlayScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlaySceneBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PlaySceneStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void PlaySceneStartMorometi()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlaySceneBack2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void PlaySceneBack3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void PlaySceneFront3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void PlaySceneTO29()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 26);
    }


    public void BackPlaySceneComentariuMoara()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void BackPlaySceneTestMoara()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 13);
    }

    public void PlaySceneTestMoara()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +  13);
    }

    public void PlaySceneComentariuIon()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void PlaySceneTestIon()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 14);
    }

    public void BackPlaySceneComentariuIon()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void BackPlaySceneTestIon()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 14);
    }
    public void PlaySceneComentariuEnigma()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void PlaySceneTestEnigma()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15);
    }

    public void BackPlaySceneComentariuEnigma()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void BackPlaySceneTestEnigma()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 15);
    }

    public void PlaySceneComentariuRiga()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void PlaySceneTestRiga()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 24);
    }

    public void backPlaySceneComentariuRiga()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void backPlaySceneTestRiga()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 24);
    }

    public void PlaySceneComentariuBaltagul()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void backPlaySceneComentariuBaltagul()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

    public void PlaySceneTestEuNuStr()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 23);
    }

    public void PlaySceneComentariuEuNuStr()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void backPlaySceneTestEuNuStr()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 23);
    }

    public void backPlaySceneComentariuEuNuStr()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }

    public void PlaySceneTestBaltagul()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 22);
    }
    public void backPlaySceneTestBaltagul()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 22);
    }

    public void PlaySceneComentariuHarapAlb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    public void PlaySceneTestHarapAlb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 21);
    }
    public void backPlaySceneComentariuHarapAlb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
    public void backPlaySceneTestHarapAlb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 21);
    }
    public void PlaySceneComentariuLuceafaru()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

    public void PlaySceneTestLuceafaru()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 16);
    }
    public void backPlaySceneComentariuLuceafaru()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }

    public void backPlaySceneTestLuceafaru()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 16);
    }

    public void PlaySceneComentariuOscrisoare()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }

    public void PlaySceneTestOscrisoare()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 20);
    }

    public void backPlaySceneComentariuOscrisoare()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }

    public void backPlaySceneTestOscrisoare()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 20);
    }

    public void PlaySceneComentariuPlumb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }

    public void PlaySceneTestPlumb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 19);
    }

    public void backPlaySceneComentariuPlumb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void backPlaySceneTestPlumb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 19);
    }

    public void PlaySceneComentariuTestament()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
    }

    public void PlaySceneTestTestament()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 18);
    }
    public void backPlaySceneComentariuTestament()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }

    public void backPlaySceneTestTestament()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 18);
    }

    public void PlaySceneComentariuUltimaNoapte()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
    }

    public void PlaySceneTestUltimaNoapte()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 17);
    }

    public void BackPlaySceneComentariuUltimaNoapte()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 12);
    }

    public void BackPlaySceneTestUltimaNoapte()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 17);
    }
    
    public void SpecialIntrebari13()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 25);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 34);
    }



    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quitgame");
    }

}
