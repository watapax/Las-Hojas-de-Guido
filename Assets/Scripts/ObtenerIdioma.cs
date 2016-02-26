using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObtenerIdioma : MonoBehaviour {


	public int indiceTexto;
	Text texto;
	SeleccionarIdioma idioma;


	public SeleccionarIdioma.TipoTexto tipoDeTexto;

	void Start()
	{
		idioma = (SeleccionarIdioma) FindObjectOfType(typeof(SeleccionarIdioma));
		texto = GetComponent<Text>();
	}

	void Update()
	{
		if(idioma.index == 2)
		{
			texto.font = idioma.japanFont;
		}
		else if(indiceTexto >= 31 && idioma.index != 2)
		{
			texto.font = idioma.creditos;
		}
		else
			texto.font = idioma.museo;

		//if(SeleccionarIdioma.instance != null)
		//texto.text = SeleccionarIdioma.instance.idiomaFinal[indiceTexto];
		if(tipoDeTexto == SeleccionarIdioma.TipoTexto.textoMenu)
			texto.text = idioma.menuIdiomaFinal[indiceTexto];
		else if(tipoDeTexto == SeleccionarIdioma.TipoTexto.textoCuento)
			texto.text = idioma.idiomaFinal[indiceTexto];


	}

}
