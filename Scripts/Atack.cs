using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    public Movimento personagem;
    // Start is called before the first frame update
    void OntriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player"){
             personagem = col.gameObject.GetComponent<Movimento>();
             personagem.vida = personagem.vida - 20;
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
