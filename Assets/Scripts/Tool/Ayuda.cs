using UnityEngine;
using System.Collections;

public class Ayuda : MonoBehaviour {

	public enum Help{nada, touch, drag, agitar, girar}
	public GameObject touch, drag, girar, agitar;

	public Help tipoAyuda;


	[HideInInspector] public GameObject ayudaObject;



	void Awake()
	{
		touch.SetActive(false);
		drag.SetActive(false);
		girar.SetActive(false);
		agitar.SetActive(false);


		touch.GetComponent<Animator>().enabled = true;
		drag.GetComponent<Animator>().enabled = true;
		girar.GetComponent<Animator>().enabled = true;
		agitar.GetComponent<Animator>().enabled = true;




	}

	public void Activar()
	{
		if(ayudaObject != null)
			ActivarAyuda();
		else
			return;

	}

	void ActivarAyuda()
	{

		ayudaObject.SetActive(true);
	}


}
