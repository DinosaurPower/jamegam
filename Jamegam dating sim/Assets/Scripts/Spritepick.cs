using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spritepick : MonoBehaviour
{

   // public int counterIndex; //this variable draws from counter script (Or a seperate script that only determines who was chosen) and gives an index of a string within appropriate array
    public int rando;
    public int slugStat;
    public int carrotStat;
    public int dolphinStat;

    public int numberr;

    //private List<int> pointList;

    public GameObject slug;
    public GameObject carrot;
    public GameObject dolphin;



    // Start is called before the first frame update
    void Start()
    {
        //calls how many points each character has recieved based on player choices (clunky but fine)
        int slugStat = GameObject.FindWithTag("SlugButton").GetComponent<Counter>().slugCount; //divide by 4??? or minus 3
        int carrotStat = GameObject.FindWithTag("CarrotButton").GetComponent<Counter>().carrotCount;
        int dolphinStat = GameObject.FindWithTag("DolphinButton").GetComponent<Counter>().dolphinCount;

        int rando = Random.Range(1, 3);

        //create a function of nested if statements
       

        
        //add other 3
        
    }



    void Update()
    {
        if (slugStat > carrotStat && slugStat > dolphinStat)
        {
            numberr = 1;
            Debug.Log("SLUG");
        }
        else if (carrotStat > slugStat && carrotStat > dolphinStat)
        {
            numberr = 2;
            Debug.Log("CARROT");
        }
        else if (dolphinStat > carrotStat && dolphinStat > slugStat)
        {
            numberr = 3;
            Debug.Log("DOLPHIN");
        }
        else
        {
            numberr = rando;
           Debug.Log(rando);
        }

       // Debug.Log(counterIndex);
    }

   public void GrandReveal()
    {
        if (numberr == 1)
        {
            slug.SetActive(true);
        } else if (numberr == 2)
        {
            carrot.SetActive(true);
        } else
        {
            dolphin.SetActive(true);
        }
    }

}
    // Update is called once per frame
    