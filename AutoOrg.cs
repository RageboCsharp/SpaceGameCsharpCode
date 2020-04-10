using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoOrg : MonoBehaviour
{

    public bool CreatingOrg = false;
    public static int orgincrease = 1;
    public int InternalIncrease;
    

   
    void Update()
    {
        orgincrease = GlobalFactory.FactorySec;
        InternalIncrease = orgincrease;
        if (CreatingOrg == false)
        {
            CreatingOrg = true;
            StartCoroutine(CreateTheOrg());

        }
    }

    IEnumerator CreateTheOrg ()
    {
        if(GlobalDNA.DNAcount == 0)
        {
            yield return new WaitForSeconds(1);        }
        else
        {
            GlobalPeople.Peoplecount += InternalIncrease;
            GlobalDNA.DNAcount -= 1;
            yield return new WaitForSeconds(1);
            CreatingOrg = false;
        }
    }
}


