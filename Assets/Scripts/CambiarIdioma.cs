using UnityEngine;
using System.Collections;

public class CambiarIdioma : MonoBehaviour {


	SeleccionarIdioma idioma;

	void OnEnable()
	{
		idioma = (SeleccionarIdioma) FindObjectOfType(typeof(SeleccionarIdioma));
	}

	public void Cambiar(int index)
	{
		idioma.ElejirIdioma(index);
	}
}
