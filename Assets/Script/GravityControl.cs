using UnityEngine;
using System.Collections;

public class GravityControl : MonoBehaviour {
	private float declinationAngle = 0.0f;
	private float noiseDeclination;

	public float playerDeclinationAngle { get { return declinationAngle * 57.3f; } }
	public float gravityDeclinationAngle { get {return noiseDeclination * 57.3f; } }

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		declinationAngle -= Input.GetAxis ("Horizontal") * Time.deltaTime;
		declinationAngle = Mathf.Clamp (declinationAngle, -1.0f, 1.0f);

		noiseDeclination = 
            Mathf.Sin (Time.realtimeSinceStartup * 3.0f)*0.7f 
            + Mathf.Sin (Time.realtimeSinceStartup * 1.71f + 2.3f)*0.3f 
            + Mathf.Sin (Time.realtimeSinceStartup * 4.71f)*0.1f;

        //Debug.Log("axes: " + (declinationAngle + noiseDeclination));

		//var direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		var direction = new Vector3(-Mathf.Sin (declinationAngle + noiseDeclination), -Mathf.Cos (declinationAngle + noiseDeclination), 0.0f);
		Physics.gravity = direction * 9.81f;
	}
}
