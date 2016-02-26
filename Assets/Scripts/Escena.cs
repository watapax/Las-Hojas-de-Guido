using UnityEngine;
using System.Collections;

public class Escena : MonoBehaviour {

	public enum Transiciones{ Corte, FadeInBlanco, FadeOutBlanco, FadeInNegro, FadeOutNegro}
	public enum ListaCanciones{ intro, arbolSinHojas, esperando, guidoTriste, incendio, devastacion, final};


	public Transiciones transicionEntrada, transicionSalida, transicionVuelta;

	public MusicManager.ListaCanciones cancion;
	public Ayuda.Help ayuda;

	Ayuda ayudaClass;

	void Awake()
	{
		ayudaClass = (Ayuda) FindObjectOfType(typeof(Ayuda));
	}






	public void ActivarMusica()
	{
		MusicManager.instance.ChequearCancion(cancion);
		MusicManager.instance.reproduciendo = cancion;
		MusicManager.instance.PlayMusic();
	}


	public void CambiarCancion()
	{
		MusicManager.instance.Transicion(cancion);
	}


	void OnEnable()
	{
		// activar Ayuda

		switch(ayuda)
		{
		case Ayuda.Help.nada:
			ayudaClass.ayudaObject = null;
			return;

		case Ayuda.Help.touch:
			ayudaClass.ayudaObject = ayudaClass.touch;
			break;

		case Ayuda.Help.drag:
			ayudaClass.ayudaObject = ayudaClass.drag;
			break;

		case Ayuda.Help.agitar:
			ayudaClass.ayudaObject = ayudaClass.agitar;
			break;

		case Ayuda.Help.girar:
			ayudaClass.ayudaObject = ayudaClass.girar;
			break;
		}
	}

}
