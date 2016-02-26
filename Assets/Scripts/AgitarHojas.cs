using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AgitarHojas : MonoBehaviour {

	public bool agitando;
	public float rango;

	void Update()
	{
		agitando = Agitando();
	}

	bool Agitando()
	{
		Vector3 movimiento = Input.acceleration;

		print (movimiento);

		if(movimiento.x < -rango || movimiento.x > rango) return true;
		else if(movimiento.y < -rango || movimiento.y > rango) return true;
		else if(movimiento.z < -rango || movimiento.z > rango) return true;
		else return false;

	}




}
