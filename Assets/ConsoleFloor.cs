using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleFloor : MonoBehaviour
{
    public Requirment a;
    public float lifetime = 20f;
    bool deathflag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (deathflag)
        {
            lifetime -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name.Contains("seafoodandmeat")
            || collision.transform.name.Contains("meatandvegetable")
            || collision.transform.name.Contains("seafoodandvegetable"))
        {
            deathflag = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        deathflag = false;
        a.total_score += (int)lifetime;
        a.total_score += 1;
        lifetime = 20f;
    }
}
