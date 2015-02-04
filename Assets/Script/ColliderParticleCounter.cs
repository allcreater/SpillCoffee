using UnityEngine;
using System.Collections;

public class ColliderParticleCounter : MonoBehaviour
{
	public int fluidParticlesCounter { get; private set; }

	void OnTriggerEnter (Collider collider)
	{
		fluidParticlesCounter++;
	}

	void OnTriggerExit (Collider collider)
	{
		fluidParticlesCounter--;
	}


	// Use this for initialization
	void Start ()
	{
		fluidParticlesCounter = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
