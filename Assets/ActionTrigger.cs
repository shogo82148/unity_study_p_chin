using UnityEngine;
using System.Collections;

public class ActionTrigger : MonoBehaviour {
	
	public float speed = 2.0f;

	// Use this for initialization
	void Start () {
		Debug.Log(speed);
	}
	
	// Update is called once per frame
	void Update () {
	Debug.Log(speed);
	}
	
	void OnTriggerStay(Collider c) {
		if(c.gameObject.tag == "Fugu") {
			Debug.Log(c.gameObject.transform.parent.gameObject.name);
			//transform.parent.transform.Translate(new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime * speed);
		}
	}
}
