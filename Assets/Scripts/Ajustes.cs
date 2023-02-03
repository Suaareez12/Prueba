using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ajustes : MonoBehaviour
{
    [SerializeField] public GameObject panelDeAjustes;
    void Start()
    {
        panelDeAjustes.SetActive(false);
    }

    public void ActivarPanel()
    {
        panelDeAjustes.SetActive(!panelDeAjustes.activeSelf);
    }

}
