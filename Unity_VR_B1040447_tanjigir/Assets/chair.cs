using UnityEngine;

public class chair : MonoBehaviour
{
    public static bool cupenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "椅子")
        {
            cupenter = true;

            print("椅子");
        }
    }
}
