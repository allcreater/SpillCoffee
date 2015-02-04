using UnityEngine;
using System.Collections;

public class GoToStart : MonoBehaviour
{
	public void LoadStartLevel()
	{
		Application.LoadLevel ("mainScene");
		Physics.gravity = new Vector3 (0.0f, -9.81f, 0.0f);
	}
}
