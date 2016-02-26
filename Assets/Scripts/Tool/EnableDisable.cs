using UnityEngine;
using System.Collections;

public class EnableDisable : MonoBehaviour {


	public GameObject objeto;
	public bool activar;

	void OnEnable()
	{
		objeto.SetActive(activar);
	}

}
