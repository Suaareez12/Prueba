using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotonJugar : MonoBehaviour
{

    [SerializeField] public Button btnJugar;
    void Start()
    {
        btnJugar = GetComponent<Button>();
        btnJugar.onClick.AddListener(JugarPrimerNivel);
    }
    public void JugarPrimerNivel()
    {
        SceneManager.LoadScene(1);
    }
}
