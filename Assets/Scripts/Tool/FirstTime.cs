using UnityEngine;
using System.Collections;

public class FirstTime : MonoBehaviour {

	public Animator hojas;

	void Start()
	{
		if(!SceneManager.instance.firstTimeApp)
		{
			hojas.SetTrigger("comenzar");
			gameObject.SetActive(false);
		}
	}



}
