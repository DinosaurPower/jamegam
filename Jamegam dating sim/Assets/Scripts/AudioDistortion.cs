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
        return Mathf.Sin(Time.time * 5);
    }
    
    // Start is called before the first frame update
    void Start()
    {
       
        
        
    }

    

    // Update is called once per frame
    void Update()
    {
//
       
    }
   
}
