using UnityEngine;
using System.Collections;

public class ParalexScroll_2 : MonoBehaviour {

	public float scrolSpeed;
	
	// Update is called once per frame
	void Update () {
	
		float x = Input.GetAxis("Horizontal");
		
		if(x != 0)
		{
			Vector3 movement = new Vector3(-x * scrolSpeed, 0f, 0f);
			transform.Translate(movement);
		}
	}
}
