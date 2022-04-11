using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    
    //setting up the numbers the way we can adjust them regards to different dialogue options
    public int slugNumber;
    public int dolphinNumber;
    public int carrotNumber;
    public GameObject NumberManager;
   
    public int slugCount;
    public int dolphinCount;
    public int carrotCount;

    // Start is called before the first frame update
    void Start()
    {
     
       
        
        StatManager statManager = NumberManager.GetComponent<StatManager>();
        //here I am getting stats from stat manager
        //it is WIP yet :p
        // slugCount = GetComponent<StatManager>().slugStat;
        //dolphinCount = GetComponent<StatManager>().dolphinStat;
        //carrotCount = GetComponent<StatManager>().carrotStat;

        slugCount = GameObject.Find("STAT_MANAGER").GetComponent<StatManager>().slugStat;
        carrotCount = GameObject.Find("STAT_MANAGER").GetComponent<StatManager>().carrotStat;
        dolphinCount = GameObject.Find("STAT_MANAGER").GetComponent<StatManager>().dolphinStat;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DolphinCount()
    {
        //counting system in work
        
        dolphinCount = dolphinCount + dolphinNumber;

        GameObject.Find("STAT_MANAGER").GetComponent<StatManager>().UpdateCount();
    }

    public void SlugCount()
    {
        slugCount = slugCount + slugNumber;
        GameObject.Find("STAT_MANAGER").GetComponent<StatManager>().UpdateCount();
    }

    public void CarrotCount()
    {
        carrotCount = carrotCount + carrotNumber;
        GameObject.Find("STAT_MANAGER").GetComponent<StatManager>().UpdateCount();
    }

}
