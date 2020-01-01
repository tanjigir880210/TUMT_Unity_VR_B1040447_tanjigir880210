using UnityEngine;

public class cup : MonoBehaviour
{
    public static bool cupenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "杯子")
        {
            cupenter = true;

            print("杯子");
        }
    }
}
