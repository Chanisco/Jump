using UnityEngine;
using System.Collections;

public class PlayerCtrlSc : MonoBehaviour {

	
	public SpriteAnimateSc sprAnim;
	// Use this for initialization
	void Start () {
		sprAnim = GetComponent<SpriteAnimateSc>();
	}
	
	// Update is called once per frame
	void Update () {
		
		float directX = Input.GetAxis("Horizontal") / 2;
		
		transform.position = new Vector3(transform.position.x + directX, transform.position.y , transform.position.z);
		
		if(Input.GetAxis("Horizontal") != 0)
		{
			sprAnim.animate(5,2,10,2);
		}
	}
}
