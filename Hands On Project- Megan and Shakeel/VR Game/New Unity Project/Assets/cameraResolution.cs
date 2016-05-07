using UnityEngine;
using System.Collections;

public class cameraResolution : MonoBehaviour {


	public float orthographicSize = 5;
	public float aspect = 1.33333f;

	// Use this for initialization
	void Start () {

		Camera.main.projectionMatrix = Matrix4x4.Ortho (
			-orthographicSize * aspect, orthographicSize * aspect,
			-orthographicSize, orthographicSize,
			1.0f, 1.0f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
