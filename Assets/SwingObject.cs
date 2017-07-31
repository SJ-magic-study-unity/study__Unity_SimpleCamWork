using UnityEngine;
using System.Collections;

public class SwingObject : MonoBehaviour {
	
	Vector3 startPosition;
	
	public float amplitude = 3.0f;
	public float speed = 2.0f;
	
	
	// Use this for initialization
	void Start () {
		startPosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		float x = amplitude * Mathf.Sin(Time.time * speed);
		transform.localPosition = startPosition + new Vector3(x, 0, 0);
	}
}
