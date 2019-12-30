using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightenter : MonoBehaviour
{
    public static bool fuckenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "燈")
        {
            fuckenter = true;

            print("燈");
        }
    }
}
