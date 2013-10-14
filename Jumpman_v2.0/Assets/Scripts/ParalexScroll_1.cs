using UnityEngine;
using System.Collections;

public class ParalexScroll_1 : MonoBehaviour {
	
	
	public float scrollSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 offset = new Vector2(scrollSpeed * Time.time,0f );
		renderer.material.SetTextureOffset("_MainTex", offset);
	}
}
