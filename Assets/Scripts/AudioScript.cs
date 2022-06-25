using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    public static AudioScript var;
    public AudioSource[] listaSunete;

    private void Awake()
    {
        var = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pornesteEfecteleDeSunet(int indexSunet)
    {
        listaSunete[indexSunet].Stop();
        listaSunete[indexSunet].Play();
    }
}
