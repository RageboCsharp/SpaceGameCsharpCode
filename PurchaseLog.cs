using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoDNA;
    public GameObject AutoOrg;

    public void StartAutoDNA()
    {
    AutoDNA.SetActive(true);

        GlobalPeople.Peoplecount -= GlobalAstroid.AstroidValue;
        GlobalAstroid.AstroidValue *= 2;
        GlobalAstroid.turnOFFbutton = true;
        GlobalAstroid.AstroidSec += 1;
        GlobalAstroid.numberofastorids += 1;
 
    }
    public void StartAutoOrg()
    {
        AutoOrg.SetActive(true);

        GlobalPeople.Peoplecount -= GlobalFactory.FactoryValue;
        GlobalFactory.FactoryValue *= 2;
        GlobalFactory.turnOFFbutton = true;
        GlobalFactory.FactorySec += 1;
        GlobalFactory.numberoffactories += 1;

    }
}