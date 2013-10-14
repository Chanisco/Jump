using UnityEngine;
using System.Collections;

public class SpriteAnimateSc : MonoBehaviour {
	
	
	
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	public void animate (int nrOfColm, int nrOfRows, int nrOfCells, int fps) {
		
		int index = (int)(fps * Time.time);
		index = index % nrOfCells;
		
		float uIndex = index % nrOfColm;
		float vIndex = index / nrOfColm;
		
		float sizeX = 1f / nrOfColm;
		float sizeY = 1f / nrOfRows;
		Vector2 size = new Vector2(sizeX,sizeY);
		
		float offsetX = sizeX * uIndex;
		float offsetY = sizeY * vIndex;
		Vector2 offset = new Vector2(offsetX,offsetY);
		
		
		
		
		renderer.material.SetTextureScale("_MainTex",size);
		renderer.material.SetTextureOffset("_MainTex", offset);
		
		Debug.Log(index);	
	}
}
