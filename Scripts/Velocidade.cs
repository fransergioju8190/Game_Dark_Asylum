using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidade : MonoBehaviour
{
    public Movimento player;
 void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){
            player = col.gameObject.GetComponent<Movimento>();
            player.velocidade+=0.1f;
        }
    }
}
