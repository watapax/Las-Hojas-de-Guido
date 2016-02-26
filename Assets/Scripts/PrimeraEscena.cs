using UnityEngine;
using System.Collections;

public class PrimeraEscena : MonoBehaviour {

	public Transform fondo,piso,cerro;
	public Transform  endpointCerro, endPointPiso;
	public float velocidad;
	public GameObject texto;
	float tiempoTranscurrido;

	void Awake()
	{
		texto.SetActive(false);
	}

	void FixedUpdate()
	{
		tiempoTranscurrido += Time.deltaTime;

		if(tiempoTranscurrido > 6)
			texto.SetActive(true);

		// mover las capas
		Mover(fondo, 0.1f);
		Mover(cerro,0.5f);
		Mover(piso, 1);

		// chequear si hay que reposicionar las capas
		ChequearEndPoint(cerro, endpointCerro, cerro.localPosition.y);
		ChequearEndPoint(piso, endPointPiso, piso.localPosition.y);
	}



	void Mover(Transform objeto, float v)
	{
		objeto.Translate(Vector2.left * velocidad * v);
	}

	void ChequearEndPoint(Transform objeto, Transform endPoint, float vOffset)
	{
		if(endPoint.position.x <= transform.position.x)
			objeto.localPosition = new Vector2(0 , vOffset);
	}


	void OnDisable()
	{
		tiempoTranscurrido = 0;
		texto.SetActive(false);
	}


}

