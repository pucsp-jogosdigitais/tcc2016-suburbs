using UnityEngine;
using System.Collections;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject Configuracoes;

    void Start()
    {

    }

    void Update()
    {

    }

    public void AtivarMenuConfiguracoes()
    {
        Configuracoes.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
