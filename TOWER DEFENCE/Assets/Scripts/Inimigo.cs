using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agente = GetComponent<NavMeshAgent>();
        GameObject FimDoCaminho = GameObject.Find("FimDoCaminho");
        Vector3 posicaoFimDoCaminho = FimDoCaminho.transform.position;
        agente.SetDestination(posicaoFimDoCaminho);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
