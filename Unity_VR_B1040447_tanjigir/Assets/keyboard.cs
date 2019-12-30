using UnityEngine;

public class keyboard : MonoBehaviour
{
    public static bool cupenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "鍵盤")
        {
            cupenter = true;

            print("鍵盤");
        }
    }
}
