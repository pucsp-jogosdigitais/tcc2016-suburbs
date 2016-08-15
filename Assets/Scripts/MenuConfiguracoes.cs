using UnityEngine;
using System.Collections;

public class MenuConfiguracoes : MonoBehaviour
{
    public GameObject Principal;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            AtivarMenuPrincipal();
    }

    public void AtivarMenuPrincipal()
    {
        Principal.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
