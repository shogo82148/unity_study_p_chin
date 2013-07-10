using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	
	public GameObject Explosion;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "Fugu") {
			Instantiate(Explosion, transform.position, Quaternion.identity);
		}
	}
}
