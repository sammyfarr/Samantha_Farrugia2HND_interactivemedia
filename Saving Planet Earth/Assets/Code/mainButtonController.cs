using UnityEngine;
using System.Collections;

public class mainButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	//50. add the code that is triggered when the image is clicked
	void OnMouseDown()
	{
		//51. Load level 1
		Application.LoadLevel (0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
