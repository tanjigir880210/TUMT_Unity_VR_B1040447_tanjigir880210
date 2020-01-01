using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printer : MonoBehaviour
{
    public static bool printerenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "列印機")
        {
            printerenter = true;

            print("列印機");
        }
    }
}
