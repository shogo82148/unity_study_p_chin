using UnityEngine;
using System.Collections;

public class MoveUV : MonoBehaviour 
{
	public Vector2 move;
	Vector2	offset;

	void Start () {

	}

	void Update () {
		offset += move * Time.deltaTime;
		renderer.material.SetTextureOffset( "_MainTex",offset );
	}
}