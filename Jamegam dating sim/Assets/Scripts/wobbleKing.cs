using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wobbleKing : MonoBehaviour
{
    //adding wobble

    public AudioDistortion wobble;
    // Start is called before the first frame update
    void Start()
    {
        AudioDistortion wobble = GameObject.Find("BGSound").GetComponent<AudioDistortion>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Wobble()
    {
        wobble.enabled = true;
    }

}
