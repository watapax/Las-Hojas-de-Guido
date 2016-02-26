using UnityEngine;
using System.Collections;

public class ActivarObject : MonoBehaviour {

	public GameObject objeto;
	void Awake()
	{
		objeto.SetActive(false);
	}

	public void Activar()
	{
		objeto.SetActive(true);
	}

}
