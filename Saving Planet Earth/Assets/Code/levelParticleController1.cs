using UnityEngine;
using System.Collections;

public class levelParticleController1 : MonoBehaviour {




	IEnumerator levelStart(){


		yield return new WaitForSeconds(9f);
		Application.LoadLevel (5);


		}
	void Start () {

		StartCoroutine ("levelStart");


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
