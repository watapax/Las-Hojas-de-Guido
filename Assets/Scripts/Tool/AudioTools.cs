using UnityEngine;
using System.Collections;

public class AudioTools : MonoBehaviour {


	AudioSource audioSource;

	void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void Start()
	{


		if(!SceneManager.instance.firstTimeApp)
			Play ();
	}
	public void ToggleMute()
	{
		audioSource.ToggleMutedAudio();
	}



	public void Play()
	{

		audioSource.Play();
	}

}
