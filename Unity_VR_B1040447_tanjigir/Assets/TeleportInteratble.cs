using UnityEngine;

public class TeleportInteratble : MonoBehaviour
{

    private void Update()
    {
        if (cup.cupenter && printer.printerenter && keyboard.keyboardenter && chair.chairenter && Lightenter.fuckenter)
        {
            gameObject.SetActive(true);
        }
    }
}
