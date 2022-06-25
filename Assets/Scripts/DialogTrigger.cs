using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Mesaj[] mesaje;
    public Actor[] actori;
    public AudioSource[] texteDialogVorbit; 

    public void StartDialog()
    {
        FindObjectOfType<DialogManager>().openDialog(mesaje, actori, texteDialogVorbit);

    }

}
[System.Serializable]
public class Mesaj
{
    public int actorID;
    public string mesaj;
    public AudioSource voceText;
}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite avatarImg;
}
