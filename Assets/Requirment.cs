using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Requirment : MonoBehaviour
{
    public GameObject[] requirments;
    public TextMesh infotext;
    public float total_time = 500f;
    public int total_score = 0;
    float lifetime = 20f;
    public bool placement = false;
    System.Random random = new System.Random();
    string finding;
    GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        int a = random.Next(0, 3);
        temp = Instantiate(requirments[a]);
        finding = temp.name;
    }

    // Update is called once per frame
    void Update()
    {
        total_time -= Time.deltaTime;
        lifetime -= Time.deltaTime;
        if (!GameObject.Find(finding))
        {
            placement = true;
            if(lifetime >= 0f)
                total_score += (int)lifetime;
        }
        if (placement)
        {
            int a = random.Next(0, 3);
            temp = Instantiate(requirments[a]);
            finding = temp.name;
            lifetime = 20f;
            placement = false;
        }
        infotext.text = "Total Score: " + total_score + "." + System.Environment.NewLine + "Time Left: " + (int)total_time + ".";
    }
}
