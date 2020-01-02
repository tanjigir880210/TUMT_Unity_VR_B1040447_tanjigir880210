using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigLight : MonoBehaviour
{
    public static bool BigLightenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "燈")
        {
            BigLightenter = true;

            print("燈");
        }
    }
}
