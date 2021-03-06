using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    public Image avataorulActorului;
    public Text numeleActorului;
    public Text mesajul;
    public AudioSource mesajTextVorbit;
    public RectTransform backgorundBox;
    Mesaj[] mesajCurent;
    Actor[] actorCurent;
    AudioSource[] audioCurent;

    int mesajActiv = 0;
    public static bool isActive = false;
    public void openDialog (Mesaj[] mesaje,Actor[] actori, AudioSource[] audio)
    {
        mesajCurent = mesaje;
        actorCurent = actori;
        audioCurent = audio;
        mesajActiv = 0;
        isActive = true;
        Debug.Log("Start conversatie" + mesaje.Length);
        Debug.Log("mesaje"+ audio.Length);
        DisplyaMesaj();
    }

    void DisplyaMesaj()
    {
        Mesaj mesajToDisplay = mesajCurent[mesajActiv];
        mesajul.text = mesajToDisplay.mesaj;

        Actor actorToDisplay = actorCurent[mesajToDisplay.actorID];
        numeleActorului.text = actorToDisplay.name;
        avataorulActorului.sprite = actorToDisplay.avatarImg;
        backgorundBox.LeanScale(Vector3.one, 0.5f);
        Debug.Log(mesajActiv);
        startSunet(mesajActiv);
        AnimateTextColor();
       

    }

    public void UrmatorulMesaj()
    {
        mesajActiv++;
        if(mesajActiv < mesajCurent.Length)
        {
            DisplyaMesaj();
        }
        else
        {
            Debug.Log("Sa terminat conversatia");
            backgorundBox.LeanScale(Vector3.zero, 0.5f);
            isActive = false;
        }
    }

    void AnimateTextColor()
    {
        LeanTween.textAlpha(mesajul.rectTransform, 0, 0);
        LeanTween.textAlpha(mesajul.rectTransform, 1, 0.5f);
    }

    public void startSunet(int indexx)
    {
        audioCurent[indexx].Stop();  

        audioCurent[indexx].Play();
    }


    // Start is called before the first frame update
    void Start()
    {
        backgorundBox.transform.localScale = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isActive == true)
        {
            UrmatorulMesaj();
        }
    }
}
