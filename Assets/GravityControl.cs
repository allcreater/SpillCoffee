using UnityEngine;
using System.Collections;

public class GravityControl : MonoBehaviour {
	private float declinationAngle = 0.0f;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		declinationAngle -= Input.GetAxis ("Horizontal") * Time.deltaTime;
		declinationAngle = Mathf.Clamp (declinationAngle, -1.0f, 1.0f);

		//var direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		var direction = new Vector3(-Mathf.Sin (declinationAngle), -Mathf.Cos (declinationAngle), 0.0f);
		Physics.gravity = direction * 9.81f;
	}
}
