using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeController : MonoBehaviour
{
    public float lifetime = 2f;
    private bool deathflag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(deathflag == true)
        {
            lifetime -= Time.deltaTime;
            if(lifetime <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name.Contains("Seafood") && !collision.transform.name.Equals("Seafood_cube(Clone)") 
            || collision.transform.name.Contains("Meat") && !collision.transform.name.Equals("Meat_cube(Clone)") 
            || collision.transform.name.Contains("Vegetable") && !collision.transform.name.Equals("Vegetable_cube(Clone)"))
        {
            deathflag = true;
        } 
    }
}
