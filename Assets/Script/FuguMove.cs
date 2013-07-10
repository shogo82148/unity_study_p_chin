using UnityEngine;
using System.Collections;

public class FuguMove : MonoBehaviour {


	public float speed = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move() {
		float horizontal = Input.GetAxis ("Horizontal");
		float vartical = Input.GetAxis ("Vertical");

		transform.Translate(new Vector3(horizontal, 0, vartical) * Time.deltaTime * speed);
	}
}