using UnityEngine;
using System.Collections;

public class HojaAgitada : MonoBehaviour {


	AgitarHojas agitarHojas;


	float velocidad = 0.008f;
	Vector2 posOriginal;
	Vector2 direccion;
	Vector2 movimiento;
	float xfinal, yFinal;

	void Awake()
	{
		posOriginal = transform.position;
		agitarHojas = GetComponentInParent<AgitarHojas>();


		Vector2 screenPos = Camera.main.WorldToScreenPoint( GetComponentInChildren<SpriteRenderer>().gameObject.transform.position) * -1;
		GetComponentInChildren<SpriteRenderer>().sortingOrder = (int)screenPos.y;

		direccion = Direccion();
	}

	Vector2 Direccion()
	{
		float x = Random.Range(-10,10);
		float y = Random.Range(-10,10);

		return new Vector2(x, y);
	}

	void FixedUpdate()
	{


		if(agitarHojas.agitando)
		{
			movimiento = Vector2.Lerp(movimiento , direccion , Time.deltaTime);
		}
		else
		{
			movimiento = Vector2.Lerp(movimiento , Vector2.zero , Time.deltaTime);
		}
		transform.Translate(movimiento * velocidad, Space.Self);
	}


	void OnDisable()
	{
		direccion = Direccion();
		transform.position = posOriginal;
	}


}

