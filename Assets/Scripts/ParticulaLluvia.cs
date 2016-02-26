using UnityEngine;
using System.Collections;

public class ParticulaLluvia : MonoBehaviour {


	public ParticleSystem particulas;
	ParticleSystem.Particle[] gota;
	int maxParticles;
	public Transform piso;


	void Awake()
	{

		maxParticles = particulas.maxParticles;
		gota = new ParticleSystem.Particle[maxParticles];
	}


	void Update()
	{
		particulas.GetParticles(gota);

		for(int i = 0; i < gota.Length; i++)
		{
			if(gota[i].position.y < piso.position.y)
			{
				gota[i].lifetime = 0;
			}
		}
	}

}
