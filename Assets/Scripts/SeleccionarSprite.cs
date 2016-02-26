using UnityEngine;
using System.Collections;

public class SeleccionarSprite : MonoBehaviour {


	public bool titulo;
	SeleccionarIdioma idioma;
	SpriteRenderer spriteRenderer;

	void Start()
	{
		idioma = (SeleccionarIdioma) FindObjectOfType(typeof(SeleccionarIdioma));
		spriteRenderer = GetComponent<SpriteRenderer>();

	}

	void Update()
	{
		if(titulo)
			spriteRenderer.sprite =  idioma.titulos[idioma.index];
		else
			spriteRenderer.sprite =	idioma.subtitulos[idioma.index];
	}



}
