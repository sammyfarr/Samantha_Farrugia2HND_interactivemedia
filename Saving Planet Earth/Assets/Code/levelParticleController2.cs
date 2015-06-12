using UnityEngine;
using System.Collections;

public class levelParticleController2 : MonoBehaviour {




	IEnumerator levelStart(){


		yield return new WaitForSeconds(2f);
		Application.LoadLevel (2);


		}
	void Start () {

		StartCoroutine ("levelStart");


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
