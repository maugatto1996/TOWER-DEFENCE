using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostradorDeBonus : MonoBehaviour
{
   private Text campoTexto;

    public Jogador jogador;


    void Start()
    {
        campoTexto = GetComponent<Text>();
    }

    
    void Update()
    {
        campoTexto.text = "Bonus: " + jogador.GetBonus();
    }
}
