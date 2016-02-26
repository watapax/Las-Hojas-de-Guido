using UnityEngine;
using System.Collections;

public class Lalopax : MonoBehaviour {


	int laloPajero = 0;

	void LaloApagaLaWea(bool valor)
	{
		gameObject.SetActive(valor);
	}


	public int laloWeonPorDos()
	{

		return laloPajero * 2;
	}

	void Update()
	{
		laloPajero++;

		if(laloWeonPorDos() >= 500)
		{
			LaloApagaLaWea(false);
		}

	}




}
