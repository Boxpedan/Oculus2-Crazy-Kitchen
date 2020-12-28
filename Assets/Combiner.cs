using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combiner : MonoBehaviour
{
    public GameObject cube;
    string saver;
    // Start is called before the first frame update
    void Start()
    {
        saver = cube.name;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(saver);
    }

    private void OnCollisionEnter(Collision collision)
    {
        string temp = saver.Replace("_cube", "");
        if (collision.transform.name.Contains(temp))
        {
            Destroy(cube);
        }
    }
}
