using UnityEngine;
using System.Collections;

public class up : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}
	
	void Move() {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		
		transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime);
	}
}
