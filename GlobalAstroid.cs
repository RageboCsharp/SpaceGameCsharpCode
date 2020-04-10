using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAstroid : MonoBehaviour
{


    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public int CurrentPeople;
    public static int AstroidValue = 10;
    public static bool turnOFFbutton = false;
    public GameObject AstroidStats;
    public static int numberofastorids;
    public static int AstroidSec;


    void Update()
    {
        CurrentPeople = GlobalPeople.Peoplecount;
        AstroidStats.GetComponent<Text>().text = "Astroids: " + numberofastorids + " @ " + AstroidSec + " DNA per second";
        fakeText.GetComponent<Text>().text = "Buy Astroid - " + AstroidValue + " Organisims";
        realText.GetComponent<Text>().text = "Buy Astroid - " + AstroidValue + " Organisims";
        if (CurrentPeople >= AstroidValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (turnOFFbutton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOFFbutton = false;
        }
    }
}
