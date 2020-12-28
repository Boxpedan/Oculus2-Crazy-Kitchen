using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Requirments_collsion : MonoBehaviour
{
    public GameObject capsule_name;
    public float lifetime = 20f;
    public TextMesh timer;
    string saver;
    // Start is called before the first frame update
    void Start()
    {
        saver = capsule_name.name;
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        timer.text = "I will leave after " + (int)lifetime + ".";
        if(lifetime <= 0)
        {
            Destroy(capsule_name);
            lifetime = 20f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string temp = saver.Replace("(Clone)", "");
        if (collision.transform.name.Contains(temp))
        {
            Destroy(capsule_name);
            lifetime = 20f;
        }
    }
}
