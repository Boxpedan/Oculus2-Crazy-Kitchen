using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CubeChecker : MonoBehaviour
{
    public TextMesh infotext;
    public GameObject cubename;
    public int numbers = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        infotext.text = "We have  " + numbers + "  of " + cubename.name + "."; 
    }

    //Check cube on
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name.Contains(cubename.name))
        {
            numbers++;
        }
    }
}
