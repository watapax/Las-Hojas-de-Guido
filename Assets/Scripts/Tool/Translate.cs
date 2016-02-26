using UnityEngine;
using System.Collections;

public class Translate : MonoBehaviour {

	public float velocidad;
	public float limiteX;

	Vector2 posOriginal;

	void Awake()
	{
		posOriginal = transform.localPosition;
	}
	void FixedUpdate()
	{

		float v = Mathf.PingPong(Time.time , velocidad * -1);
		transform.Translate(Vector2.right * velocidad * Time.deltaTime * v);

		if(transform.localPosition.x <= limiteX)
			transform.localPosition = posOriginal;
	}

}
