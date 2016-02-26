using UnityEngine;
using System.Collections;

public class HojasFuera : MonoBehaviour {

	Animator anim;
	public bool fuera;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	void Start()
	{
		if(fuera)
		{
			anim.SetTrigger("trans");
		}
	}

}
