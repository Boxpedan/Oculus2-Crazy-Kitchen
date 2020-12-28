using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonInteraction : MonoBehaviour
{

    public TextMeshProUGUI simpleUIText;
    public CubeChecker seafood;
    public CubeChecker meat;
    public CubeChecker vegetable;
    public int SM = 0;
    public int SV = 0;
    public int MV = 0;
    public TextMesh infotext;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        infotext.text = "We have:" + System.Environment.NewLine + SM + " Seafood Meat combuine." + System.Environment.NewLine + SV + " Seafood Vegetable combine." + System.Environment.NewLine + MV+" Meat Vegetable combine.";
 
    }
    public void OnButton1Clicked()
    {
        if(seafood.numbers > 0 && meat.numbers > 0)
        {
            seafood.numbers--;
            meat.numbers--;
            SM++;
            simpleUIText.text = "SE & MT combined.";
        }
        else
            simpleUIText.text = "No Enough Material";
    }

    public void OnButton2Clicked()
    {
        if (seafood.numbers > 0 && vegetable.numbers > 0)
        {
            seafood.numbers--;
            vegetable.numbers--;
            SV++;
            simpleUIText.text = "SE & VG combined.";
        }
        else
            simpleUIText.text = "No Enough Material";
    }


    public void OnButton3Clicked()
    {
        if (meat.numbers > 0 && vegetable.numbers > 0)
        {
            vegetable.numbers--;
            meat.numbers--;
            MV++;
            simpleUIText.text = "MT & VG combined.";
        }
        else
            simpleUIText.text = "No Enough Material";
    }


}
