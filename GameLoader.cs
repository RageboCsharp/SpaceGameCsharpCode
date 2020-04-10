using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedDNA;
    public int savedPeople;
    public int savedAstroids;
    public int savedFactories;
    public int savedValue;


    void Start()
    {
      if (MainMenuOptionsA.isLoading == true)
        {
            savedDNA = PlayerPrefs.GetInt("SavedDNA");
            GlobalDNA.DNAcount = savedDNA;
            savedPeople = PlayerPrefs.GetInt("SavedOrganisms");
            GlobalPeople.Peoplecount = savedPeople;
            savedAstroids = PlayerPrefs.GetInt("SavedAstroids");
            AutoDNA.DNAincrease = savedAstroids;
            GlobalAstroid.AstroidSec = savedAstroids;
            GlobalAstroid.numberofastorids = savedAstroids;
            savedFactories = PlayerPrefs.GetInt("SavedOrganismFactorys");
            AutoOrg.orgincrease = savedFactories;
            GlobalFactory.FactorySec = savedFactories;
            GlobalFactory.numberoffactories = savedFactories;
            savedValue = PlayerPrefs.GetInt("saveValue");
            SAVEgame.SAVEvalue = savedValue;
        }  
    }

}
