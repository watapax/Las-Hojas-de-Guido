using UnityEngine;
using System.Collections;

public static class ExtensionMethod 
{
	///<summary>
	/// activa o desactive el mute del AudioSource
	///</summary>
	public static void ToggleMutedAudio(this AudioSource audioSource)
	{
		audioSource.mute = !audioSource.mute;
	}

}
