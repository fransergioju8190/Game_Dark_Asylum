using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Movimento : MonoBehaviour
{
	private CharacterController character;
	private Animator animator;
	private Vector3 inputs;
	public int vida = 100;
	public Slider barra;
	public Transform A;
	public Slider B;	
	[SerializeField] public float velocidade;


	void Start()
	{
		character = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		barra.value = vida;
		B.value = velocidade;
		if(vida <=0){
			SceneManager.LoadScene("Jogo 2");
		}
		inputs.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		character.Move((transform.forward * inputs.magnitude * Time.deltaTime * velocidade));
		character.Move((Vector3.down * Time.deltaTime));

		if (inputs != Vector3.zero)
		{
			animator.SetBool("Walk", true);
			transform.forward = Vector3.Slerp(transform.forward, inputs, Time.deltaTime * 10);
		}
		else
		{
			animator.SetBool("Walk", false);
		}
    }
	void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Speed"){
            velocidade+=0.9f;
        }else if(col.gameObject.tag == "Atack"){
            vida-=20;
        }else if(col.gameObject.tag == "ganhoVida"){
            vida+=20;
			Destroy(col.gameObject);
	}else if(col.gameObject.tag == "A"){
            SceneManager.LoadScene("Jogo 1");
	}
	}
}

