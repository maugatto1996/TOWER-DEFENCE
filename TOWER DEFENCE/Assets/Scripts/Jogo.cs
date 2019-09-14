using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour
{
    [SerializeField] private GameObject torrePrefab;


    void Update()
    {
        if (ClicouComBotaoPrimario())
        {
            ConstruirTorre();
        }   
    }

    private bool ClicouComBotaoPrimario()
    {
        return Input.GetMouseButtonDown(0); 
    }

    private void ConstruirTorre()
    {
        Vector3 posicaoDoClique = Input.mousePosition;
        RaycastHit elementoAtingidoPeloRaio = DisparaRaioDaCameraAteUmPonto(posicaoDoClique);
        if(elementoAtingidoPeloRaio.collider != null)
        {
            Vector3 posicaoDoElemento = elementoAtingidoPeloRaio.point;
            Instantiate(torrePrefab, posicaoDoElemento, Quaternion.identity);
        }
    }

    private RaycastHit DisparaRaioDaCameraAteUmPonto(Vector3 ponto)
    {
        Ray raio = Camera.main.ScreenPointToRay(ponto);
        RaycastHit elementoAtingidoPeloRaio;
        float comprimentoMaximoDoRaio = 100f;
        Physics.Raycast(raio, out elementoAtingidoPeloRaio, comprimentoMaximoDoRaio);

        return elementoAtingidoPeloRaio;
    }

}
