using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Mesaj[] mesaje;
    public Actor[] actori;

    public void StartDialog()
    {
        FindObjectOfType<DialogManager>().openDialog(mesaje, actori);

    }

}
[System.Serializable]
public class Mesaj
{
    public int actorID;
    public string mesaj;
}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite avatarImg;
}
