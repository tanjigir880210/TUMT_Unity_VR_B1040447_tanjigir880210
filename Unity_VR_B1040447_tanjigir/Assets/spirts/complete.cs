using UnityEngine;
using UnityEngine.UI;

public class complete : MonoBehaviour
{
    public GameObject end;

    private void Update()
    {
        if (cup.cupenter && printer.printerenter && keyboard.keyboardenter && chair.chairenter && BigLight.BigLightenter && flowerpot.flowerpotenter)
        {
            end.SetActive(true);

            print("enter");
        }
    }
}
