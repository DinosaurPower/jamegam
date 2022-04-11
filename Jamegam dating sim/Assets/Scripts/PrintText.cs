using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrintText : MonoBehaviour
{

    public int counterIndex; //this variable draws from counter script (Or a seperate script that only determines who was chosen) and gives an index of a string within appropriate array
    public float typeSpeed = 0.1f;
    public TMP_Text textDisplay;
    public int slugStat;
    public int dolphinStat;
    public int carrotStat;

    private string sentence;
    //private List<int> pointList;

    private int slugCount;
    private int dolphinCount;
    private int carrotCount;




    // Start is called before the first frame update
    void Start()
    {
        //calls how many points each character has recieved based on player choices (clunky but fine)
        int slugStat = GameObject.FindWithTag("SlugButton").GetComponent<Counter>().slugCount; //divide by 4??? or minus 3
        int carrotStat = GameObject.FindWithTag("CarrotButton").GetComponent<Counter>().carrotCount;
        int dolphinStat = GameObject.FindWithTag("DolphinButton").GetComponent<Counter>().dolphinCount;

        //idk wtf this shit code is
        //int slugCount = GameObject.Find("STAT_MANAGER").GetComponent<StatManager>().slugStat;
        //int carrotCount = GameObject.Find("STAT_MANAGER").GetComponent<StatManager>().carrotStat;
        //int dolphinCount = GameObject.Find("STAT_MANAGER").GetComponent<StatManager>().dolphinStat;

        int rando = Random.Range(0, 3);

        SortPoints();

        Debug.Log(counterIndex);
        string[] introResponse = { "You approach your cute date as your heart palpitates and throbs. You feel the sweetness of love in the air. But oh no! Due to lighting conditions you are unable to recognize your lovely date’s features." };
        string[] greetingResponse = { "You look super hot and modest.", "I brought you a milk carton ring! It is a popular gift in my home, do you LOVE it? *YOU’VE OBTAINED A CARTON RING*", "I love your wide stance, and you’ll pay? Step on me ;)" };
        //string[] complimentResponse = { " I’ve just had a tan! Do I look too orange???????", "Thank you, I use Vaseline to keep my body moist!!", "Thank you, I’ve got it from my mother!" };
        //string[] foodResponse = { "My grandfather died in the same circumstances...", "Good choice. And I would love a pitcher of water, please.", "Good choice, lettuce is so ALTERNATIVE." };
        //string[] interestsResponse = { "Oh I've seen star wars! I’ve bought some for my kids but they are too young to play with legos, they make the most abominable creations. So I do it myself.", "I love star wars! In Attack Of The Clones, we can clearly see that Anakin's shadow on the wall of the moisture farmhouse is reminiscent of Darth Vader's striking silhouette.", "ewwwww, so basic. I prefer hungarian arthouse, it does not kiss Disney’s ass." };
        sentence = introResponse[counterIndex]; 
        sentence = greetingResponse[counterIndex];
        SortPoints();
        //DisplayNextSentence();
        //add other 3

    }

    

    public void SortPoints()
    {
        //create a function of nested if statements
        if (slugStat > carrotStat && slugStat > dolphinStat)
        {
            counterIndex = 2;
            Debug.Log("SLUG");
            DisplayNextSentence();
        }
        else if (carrotStat > slugStat && carrotStat > dolphinStat)
        {
            counterIndex = 0;
            Debug.Log("CARROT");
            DisplayNextSentence();
        }
        else if (dolphinStat > carrotStat && dolphinStat > slugStat)
        {
            counterIndex = 1;
            Debug.Log("DOLPHIN");
            DisplayNextSentence();
        }
        else
        {
            counterIndex = 0; // change to rando and add duplicates in intro string array
            //Debug.Log(rando);
            DisplayNextSentence();
        }
    }

    public void DisplayNextSentence()
    {
        textDisplay.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    private IEnumerator TypeSentence(string sentence)
    {
        textDisplay.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            textDisplay.text += letter;

            yield return new WaitForSeconds(typeSpeed);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
