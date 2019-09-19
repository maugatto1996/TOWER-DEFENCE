using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{

    private float velocidade = 10f;
    private Inimigo alvo;
    [SerializeField] private int pontosDeDano;
    

    void Start()
    {
        
        AutoDestruirDepoisDeSegundo(4);
    }

    public void DefineAlvo(Inimigo inimigo)
    {
        alvo = inimigo;
    }


    void Update()
    {
        Anda();
        AlteraDirecao();

    }

    private void Anda()
    {
        Vector3 posicaoAtual = transform.position;
        Vector3 deslocamento = transform.forward * Time.deltaTime * velocidade;
        transform.position = posicaoAtual + deslocamento;
    }

    private void AlteraDirecao()
    {
        Vector3 posicaoAtual = transform.position;
        Vector3 posicaoDoAlvo = alvo.transform.position;
        Vector3 dircaoDoAlvo = posicaoDoAlvo - posicaoAtual;
        transform.rotation = Quaternion.LookRotation(dircaoDoAlvo);
    }

    void OnTriggerEnter(Collider elementoColidido)
    {
        if (elementoColidido.CompareTag("Inimigo"))
        {
            Destroy(this.gameObject);
            
            //Destroy(elementoColidido.gameObject);
            Inimigo inimigo = elementoColidido.GetComponent<Inimigo>();
            inimigo.RecebeDano(pontosDeDano);
        }
    }

    private void AutoDestruirDepoisDeSegundo(float segundos)
    {
        Destroy(this.gameObject, segundos);
    }
}
