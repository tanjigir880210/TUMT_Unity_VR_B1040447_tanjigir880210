using UnityEngine;

public class keyboard : MonoBehaviour
{
    public static bool keyboardenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "鍵盤")
        {
            keyboardenter = true;

            print("鍵盤");
        }
    }
}
