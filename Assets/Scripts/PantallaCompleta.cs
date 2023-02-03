using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaCompleta : MonoBehaviour
{

    public static bool fullScreen;

    void Start()
    {
        // Toggle fullscreen
        Screen.fullScreen = !Screen.fullScreen;
    }
}