using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogador : MonoBehaviour
{
    [SerializeField] private int vida;

    [SerializeField] private int bonus;
    public int GetVida(){
        return vida;
    }

    public void PerdeVida(){
        vida --;
    }

    public void AumentaVida(){
        vida ++;
    }

    public int GetBonus(){
        return bonus;   
    }
    
    public void AumentaBonus(){
        bonus ++;
        if(bonus >= 3){
            AumentaVida();
            ZeraBonus();

        }

    }

    public void ZeraBonus(){
        bonus = 0;
    }


}
