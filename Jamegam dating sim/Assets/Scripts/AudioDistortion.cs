using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioDistortion : MonoBehaviour
{
    public AudioMixer masterMixer;
    public float wobblelvl;
    float wobblesin()
    {
        return Mathf.Sin(Mathf.Sin(Time.time * 200) / 20);
    }

    // Start is called before the first frame update
    void Start()
    {



    }

    void FixedUpdate()
    {
        // wobblelvl = wobblesin+1;
        masterMixer.SetFloat("Pitch", wobblesin() + 1);
    }

    // Update is called once per frame
    void Update()
    {
        //

    }
    public void killEars()
    {
        masterMixer.SetFloat("Pitch", wobblesin());
    }
}