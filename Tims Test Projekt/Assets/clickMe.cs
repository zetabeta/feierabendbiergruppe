using UnityEngine;
using System.Collections;

public class clickMe : MonoBehaviour {

	private float degrees = 0;

	// Use this for initialization
	void Start () {
	Debug.Log ("Hello World");	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		degrees = degrees + 25;
		GameObject.FindGameObjectWithTag("Scheibe").transform.localRotation=Quaternion.Euler (0,degrees,0);

	}
}
