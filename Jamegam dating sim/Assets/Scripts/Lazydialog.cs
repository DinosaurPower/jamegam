using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Lazydialog : MonoBehaviour
{
    public int counterIndex; //this variable draws from counter script (Or a seperate script that only determines who was chosen) and gives an index of a string within appropriate array
    public float typeSpeed = 0.1f;
    public TMP_Text textDisplay;

    private string sentence;
    //list of phrases
   
    // public int counterIndex; //this variable draws from counter script (Or a seperate script that only determines who was chosen) and gives an index of a string within appropriate array
    public int rando;
    public int slugStat;
    public int carrotStat;
    public int dolphinStat;
    //creating a string
    public string[] godzillabanana = new string[3];
    public int numbrawr;

    //private List<int> pointList;




    // Start is called before the first frame update
    void Start()
    {

        int slugStat = GameObject.FindWithTag("SlugButton").GetComponent<Counter>().slugCount; //divide by 4??? or minus 3
        int carrotStat = GameObject.FindWithTag("CarrotButton").GetComponent<Counter>().carrotCount;
        int dolphinStat = GameObject.FindWithTag("DolphinButton").GetComponent<Counter>().dolphinCount;
        //calls how many points each character has recieved based on player choices (clunky but fine)




        //create a function of nested if statements



        //add other 3

    }


    //numbrawr
    void Update()
    {
        if (slugStat > carrotStat && slugStat > dolphinStat)
        {
            numbrawr = 1;
            Debug.Log("SLUG");
        }
        else if (carrotStat > slugStat && carrotStat > dolphinStat)
        {
            numbrawr = 2;
            Debug.Log("CARROT");
        }
        else if (dolphinStat > carrotStat && dolphinStat > slugStat)
        {
            numbrawr = 3;
            Debug.Log("DOLPHIN");
        }
        else
        {
            numbrawr = rando;
            Debug.Log(rando);
        }
        DisplayNextSentence();

        sentence = godzillabanana[numbrawr];


        // Debug.Log(counterIndex);
    }

    public void GrandReveal()
    {
        if (numbrawr == 1)
        {
          
        }
        else if (numbrawr == 2)
        {
           
        }
        else
        {
            
        }
    }
    public void DisplayNextSentence()
    {
        textDisplay.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    //one by one each letter layout
    private IEnumerator TypeSentence(string sentence)
    {
        textDisplay.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            textDisplay.text += letter;

            yield return new WaitForSeconds(typeSpeed);
        }
    }

}