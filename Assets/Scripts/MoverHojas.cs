using UnityEngine;
using System.Collections;

public class MoverHojas : MonoBehaviour {

	public AudioClip tomaHoja, sueltaHoja;

	Vector2 offset;
	[HideInInspector] public Vector2 posOriginal;
	AudioSource audioSource;


	void Awake()
	{
		if(transform.parent.GetComponent<AudioSource>() != null)
			audioSource = GetComponentInParent<AudioSource>();
	}

	void OnMouseDown()
	{

		GuidoComiendo.hoja = null;
		offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
		audioSource.PlayOneShot(tomaHoja);
	}

	void OnMouseDrag()
	{
		GetComponent<SpriteRenderer>().sortingOrder = 10;
		Vector2 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = posicionMouse + offset;
	}

	void OnMouseUp()
	{
		GetComponent<SpriteRenderer>().sortingOrder = 3;
		GuidoComiendo.hoja = gameObject;
		audioSource.PlayOneShot(sueltaHoja);
	}



}
