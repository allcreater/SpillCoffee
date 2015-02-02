using UnityEngine;
using System.Collections;

public class GravityOrientation : MonoBehaviour
{
	private Quaternion initialOrientation;
	// Use this for initialization
	void Start ()
	{
		initialOrientation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.rotation = initialOrientation * Quaternion.AngleAxis (Mathf.Atan2 (Physics.gravity.x, -Physics.gravity.y) * 57.3f, new Vector3 (0.0f, 0.0f, 1.0f));
	}
}
