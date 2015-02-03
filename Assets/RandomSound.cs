using UnityEngine;
using System.Collections;

public class RandomSound : MonoBehaviour {
	public AudioClip[] sourceSounds;
	public int numIterationsToPlay = 1;
	public float delayBetweenSounds = 0.0f;
	// Use this for initialization
	IEnumerator Start ()
	{
		for (int i = 0; i < numIterationsToPlay; i++)
		{
			int clipIndex = Random.Range (0, sourceSounds.Length - 1);
			AudioClip currentClip = sourceSounds[clipIndex];

			audio.PlayOneShot (currentClip);
			yield return new WaitForSeconds(currentClip.length + delayBetweenSounds);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
