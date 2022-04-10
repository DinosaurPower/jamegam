using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDistortion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        m_Play = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
