using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private string targetTag = "BTrigger";

    private int BounceCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            BounceCount++;
            print("Total bounces:" + BounceCount);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
