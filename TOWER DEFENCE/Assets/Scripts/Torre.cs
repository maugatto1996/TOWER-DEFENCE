using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{

    public GameObject projetilPrefab;
    public float tempoDeRecarga = 1f;
    private float momentoDoUltimoDisparo;



    void Start()
    {
        Atira();
    }

    
    void Update()
    {
        Atira();
    }

    private void Atira()
    {
        float tempoAtual = Time.time;
        if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga)
        {
            momentoDoUltimoDisparo = tempoAtual;
            GameObject pontoDeDisparo = this.transform.Find("CanhaoDaTorre/PontoDeDisparo").gameObject;
            Vector3 posicaoDoPontoDeDisparo = pontoDeDisparo.transform.position;
            Instantiate(projetilPrefab, posicaoDoPontoDeDisparo, Quaternion.identity);
        }
    }
}
