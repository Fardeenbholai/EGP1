using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecoin : MonoBehaviour
{
    // Start is called before the first frame update
    private int rotatespeed;
    void Start()
    {
        rotatespeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotatespeed,0,Space.World);
    }
}
