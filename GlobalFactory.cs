using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFactory : MonoBehaviour
{


    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public int CurrentPeople;
    public static int FactoryValue = 10;
    public static bool turnOFFbutton = false;
    public GameObject FactoryStats;
    public static int numberoffactories;
    public static int FactorySec;


    void Update()
    {
        CurrentPeople = GlobalPeople.Peoplecount;
        FactoryStats.GetComponent<Text>().text = "Organism Facories: " + numberoffactories + " @ " + FactorySec + " People per second";
        fakeText.GetComponent<Text>().text = "Buy Organism Factory - " + FactoryValue + " Organisims";
        realText.GetComponent<Text>().text = "Buy Factory - " + FactoryValue + " Organisims";
        if (CurrentPeople >= FactoryValue)
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
