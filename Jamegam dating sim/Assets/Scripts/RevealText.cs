using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RevealText : MonoBehaviour
{
    private readonly string sentence;

    public TMP_Text textDisplay;
    public float typeSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        DisplayNextSentence();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayNextSentence()
    {
        textDisplay.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    
    private IEnumerator TypeSentence(string sentence)
    {
        this.textDisplay.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            this.textDisplay.text += letter;

            yield return new WaitForSeconds(typeSpeed);
        }
    }
}
