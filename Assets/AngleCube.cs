using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCube : MonoBehaviour
{
    public GameObject[] materials;
    public float duration = 2f;
    System.Random random = new System.Random();
    float y = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        int a = random.Next(0, 3);
        int x = random.Next(-48,48);
        int z = random.Next(-48, 0);
        Instantiate(materials[a],new Vector3(x,y,z),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        duration -= Time.deltaTime;
        if(duration <= 0)
        {
            int a = random.Next(0, 3);
            int x = random.Next(-48, 48);
            int z = random.Next(-48, 0);
            Instantiate(materials[a], new Vector3(x, y, z), Quaternion.identity);
            duration = 2f;
        }
    }
}
