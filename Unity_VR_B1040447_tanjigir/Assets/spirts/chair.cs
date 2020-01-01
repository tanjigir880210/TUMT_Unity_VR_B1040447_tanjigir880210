using UnityEngine;

public class chair : MonoBehaviour
{
    public static bool chairenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "椅子")
        {
            chairenter = true;

            print("椅子");
        }
    }
}
