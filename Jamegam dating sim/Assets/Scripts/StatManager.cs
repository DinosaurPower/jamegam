using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    //this is scored numbers, they will be used later to pick dialogue options and activate proper sprites
    public int slugStat;
    public int dolphinStat;
    public int carrotStat;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void UpdateCount()
    {
        slugStat = GameObject.Find("SlugButton").GetComponent<Counter>().slugCount;
        carrotStat =  GameObject.Find("CarrotButton").GetComponent<Counter>().carrotCount;
        dolphinStat = GameObject.Find("DolphinButton").GetComponent<Counter>().dolphinCount;
    }
}
