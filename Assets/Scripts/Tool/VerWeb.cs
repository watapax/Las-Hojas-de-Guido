using UnityEngine;
using System.Collections;

public class VerWeb : MonoBehaviour {

	public void OpenUrl(string url)
	{
		Application.OpenURL(url);
	}
}
