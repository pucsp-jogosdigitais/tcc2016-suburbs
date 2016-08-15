using UnityEngine;
using System.Collections;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject Configuracoes;
    public GameObject Principal;

    void Start()
    {

    }

    void Update()
    {
               if (Input.GetKeyDown(KeyCode.Escape)) {
			AtivarMenuConfiguracoes();
		}
    }

    public void AtivarMenuConfiguracoes()
    {
        Configuracoes.SetActive(false);
        Principal.SetActive(true);
// Caso tenha outros menus coloca-los como desativados deixando somente o menu principal
    }
}
