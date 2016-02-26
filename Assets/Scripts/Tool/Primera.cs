using UnityEngine;
using System.Collections;

public class Primera : MonoBehaviour {


	public GameObject botonAtras, botonAdelante;
	bool _activarBoton;

	public bool ActivarBoton
	{
	   	get {return _activarBoton;}
		set {_activarBoton = value;}

	}

	void OnEnable()
	{
		botonAtras.SetActive(false);
		botonAdelante.SetActive(false);
	}

	void Update()
	{
		if(_activarBoton)
			botonAdelante.SetActive(true);
	}



}
