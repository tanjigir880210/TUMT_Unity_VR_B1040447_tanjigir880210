using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public static bool cupenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "燈")
        {
            cupenter = true;

            print("燈");
        }
    }
}
