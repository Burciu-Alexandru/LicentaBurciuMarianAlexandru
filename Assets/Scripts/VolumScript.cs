using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumScript : MonoBehaviour
{

    public AudioSource bgmusic;
    // Start is called before the first frame update
    void Start()
    {
        bgmusic.volume = 0.3f;
        bgmusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        bgmusic.volume = 0.3f;
        
    }
}
