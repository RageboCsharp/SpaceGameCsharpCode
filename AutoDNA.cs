using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDNA : MonoBehaviour
{

    public bool CreatingDNA = false;
    public static int DNAincrease = 1;
    public int InternalIncrease;
    

   
    void Update()
    {
        DNAincrease = GlobalAstroid.AstroidSec;
        InternalIncrease = DNAincrease;
        if (CreatingDNA == false)
        {
            CreatingDNA = true;
            StartCoroutine(CreateTheDNA());

        }
    }

    IEnumerator CreateTheDNA ()
    {
        GlobalDNA.DNAcount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingDNA = false;
    }
}


