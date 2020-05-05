using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        audioData.time = 73.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(audioData.time > 99.5) { audioData.Pause(); }
    }
}
