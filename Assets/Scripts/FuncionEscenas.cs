using UnityEngine;
using System.Collections;

public class FuncionEscenas : MonoBehaviour {

	public int _indice;
	public void CambiarEscena2()
	{
		SceneManager.instance.CargarEscena(_indice);
	}

	public void CambiarEscena(int indice)
	{
		SceneManager.instance.CargarEscena(indice);

	}



}
