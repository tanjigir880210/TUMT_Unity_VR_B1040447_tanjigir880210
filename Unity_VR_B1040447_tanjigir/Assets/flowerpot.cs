using UnityEngine;

public class flowerpot : MonoBehaviour
{
    public static bool flowerpotenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "花盆")
        {
            flowerpotenter = true;

            print("花盆");
        }
    }
}
