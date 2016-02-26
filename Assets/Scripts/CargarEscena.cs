using UnityEngine;
using System.Collections;

public class CargarEscena : MonoBehaviour {

	public static int index = 0;
	public static CargarEscena instance;


	void Awake()
	{
		if(instance != null)
		{
			if(instance != this)
				Destroy(gameObject);
		}
		else
			instance = this;

		DontDestroyOnLoad(this);
	}


}
