using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BotonTool : MonoBehaviour {

	Text textoBoton;
	//Image imagen;
	bool toggle;


	void Awake()
	{
		textoBoton = GetComponentInChildren<Text>();
		//imagen = GetComponent<Image>();
	}

	public void ToggleAudio()
	{
		toggle = !toggle;

	}

	void Update()
	{
		if(toggle)
			textoBoton.text = SeleccionarIdioma.instance.menuIdiomaFinal[3];
		else
			textoBoton.text = SeleccionarIdioma.instance.menuIdiomaFinal[2];
	}


}
