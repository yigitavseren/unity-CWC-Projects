using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Hangi kameralarý deðiþtireceðimizi bilmemiz lazým.
    // Bunlarý Inspector'dan sürükleyip býrakacaðýz.
    public Camera thirdPersonCamera;
    public Camera firstPersonCamera;

    // Hangi tuþla deðiþtireceðiz?
    public KeyCode switchKey = KeyCode.C; // "C" tuþu

    // Update is called once per frame
    void Update()
    {
        // Eðer "switchKey"e (C tuþuna) BASILDIÐI ANI yakalarsak...
        if (Input.GetKeyDown(switchKey))
        {
            // Ýkisini de tersine çevir!
            // 3. þahýs kameranýn "enabled" (açýk olma) durumu, þu an neyse tam tersi olsun.
            thirdPersonCamera.enabled = !thirdPersonCamera.enabled;

            // 1. þahýs kameranýn "enabled" durumu da tam tersi olsun.
            firstPersonCamera.enabled = !firstPersonCamera.enabled;
        }
    }
}