using UnityEngine;
using System.Collections;

public class ActionTrigger : MonoBehaviour {

	public float speed = 3.0f;

	void Start () {
	}
	
	void Update () {
	}

	void OnTriggerStay(Collider c){
		if (c.gameObject.tag == "EnemyTarget") {
			transform.parent.LookAt(c.gameObject.transform.parent);
			transform.parent.Translate(new Vector3(0, 0, 1.0f) * Time.deltaTime);
		}

	}
}
