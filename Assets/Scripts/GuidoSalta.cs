using UnityEngine;
using System.Collections;

public class GuidoSalta : MonoBehaviour {

	//Animator animGuido;
	public Animator animShake;
	AudioSource audioSource;


	void Awake()
	{

		//animGuido = GetComponent<Animator>();


	}



	public void Shake()
	{
		animShake.SetTrigger("shake");
	}



}
