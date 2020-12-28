using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationController : MonoBehaviour
{
    public ButtonInteraction temp;
    public GameObject[] combiners;
    int svcounter = 0;
    int smcounter = 0;
    int mvcounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(svcounter <= temp.SV)
        {
            int x = temp.SV - svcounter;
            for(int i = 0; i < x; i++)
            {
                Instantiate(combiners[0]);
            }
            svcounter += x;
        }

        if (smcounter <= temp.SM)
        {
            int y = temp.SM - smcounter;
            for (int i = 0; i < y; i++)
            {
                Instantiate(combiners[1]);
            }
            smcounter += y;
        }

        if (mvcounter <= temp.MV)
        {
            int z = temp.MV - mvcounter;
            for (int i = 0; i < z; i++)
            {
                Instantiate(combiners[2]);
            }
            mvcounter += z;
        }
    }
}
