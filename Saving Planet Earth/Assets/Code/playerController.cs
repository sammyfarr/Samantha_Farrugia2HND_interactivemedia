using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{

		//24. create a public variable for the GUI skin
		public GUISkin style;

		//25. create a public variable for the number of lives
		public int lives;
		public int score;
		public GameObject particle;
		public GameObject levelParticle;
		public GameObject invincibleBall;

		//1. declare a variable for the animator
		Animator anim;

		//4. declare a boolean jump
		bool jump;
		
		
		//35. Declare a variable for the current time
		float currentTime;
		
		//36. Declare a variable for the start time
		float startTime;
		bool invincible = false;
		public AudioClip pointsSound;
		public AudioClip explosion;

		//26. create the OnGUI method
		void OnGUI ()
		{

				

				//28. apply the style sheet	
				GUI.skin = style;
				//27. create a label 10 to the right and 10 further down from the top left corner
				GUI.Label (new Rect (10f, 10f, 150f, 30f), "Lives: " + lives);
				
				

				GUI.Label (new Rect (10f, 40f, 150f, 30f), "Score: " + score);

		
				
		}

		GameObject ball;

		//29. Collision function between player and obstacle
		void OnTriggerEnter2D (Collider2D otherObject)
		{
				//30. check the tag of the object I hit.  if it is an obstacle..
				if (otherObject.tag == "obstacle") {
						//31. destroy the obstacle

						AudioSource audio = GetComponent<AudioSource> ();
			
			
						audio.PlayOneShot (explosion);

						Instantiate (particle, transform.position, transform.rotation);
						Destroy (otherObject.gameObject);
						
				

						if (otherObject.tag == "particle") {
								
			
								Destroy (otherObject.gameObject);

							

						}
		
						//32. reduce lives by 1
						if (invincible == false) {
								lives--;
						}
						//33. if lives are 0
						if (lives == 0) {
								//34. game over, go to game over screen
								Application.LoadLevel ("gameover");
						}
				}

				if (otherObject.tag == "invincibility") {



						StartCoroutine ("setInvincible");
						
						//Destroy (this.gameObject);


				}

				if (otherObject.tag == "animal") {

		
						Destroy (otherObject.gameObject);

						AudioSource audio = GetComponent<AudioSource> ();

					
						audio.PlayOneShot (pointsSound);
				

						score += 50;

				}

				if (otherObject.tag == "flower") {
						
						AudioSource audio = GetComponent<AudioSource> ();
			
			
						audio.PlayOneShot (pointsSound);

						Destroy (otherObject.gameObject);
						score += 10;

				}

				if (otherObject.tag == "water") {

						AudioSource audio = GetComponent<AudioSource> ();
			
			
						audio.PlayOneShot (pointsSound);

						Destroy (otherObject.gameObject);
						score += 30;

				}

				if (otherObject.tag == "powerstation") {
						
						Instantiate (particle, transform.position, transform.rotation);

						AudioSource audio = GetComponent<AudioSource> ();
			
			
						audio.PlayOneShot (explosion);

						Destroy (otherObject.gameObject);

						score -= 50;

				}

				if (otherObject.tag == "heart") {
						AudioSource audio = GetComponent<AudioSource> ();


						audio.PlayOneShot (pointsSound);
						Destroy (otherObject.gameObject);
			
						lives++;
			
				}









				//other objects and changes the properties of the objects

		}

		IEnumerator setInvincible ()
		{

		ball = (GameObject)Instantiate (invincibleBall, new Vector3 (transform.position.x, transform.position.y, -0.1f), transform.rotation);
				invincible = true;

				yield return new WaitForSeconds (10f);
				if (ball != null) {
						Destroy (ball);
				}
				invincible = false;

		}
		

		// Use this for initialization
		void Start ()
		{
			if (Application.loadedLevel == 1) {

					score = 0;


				}
		if (Application.loadedLevel == 2) {
			
			score = 301;
			
			
		}

		if (Application.loadedLevel == 3) {
			
			score = 501;
			
			
		}
			
				//2. assign the animator according to the animator component in the player
				anim = GetComponent<Animator> ();

				

		}

		//6. jump the box upwards for 0.5 seconds
		IEnumerator jumpBox ()
		{
				//12. Set the position of the player to jumped
				transform.position = new Vector3 (-7f, -1f, 0f);
		
				//7. the jump animation will become true
				jump = true;
				//8. set the animator parameter
		
				//9. Wait for 0.5 seconds
				yield return new WaitForSeconds (0.5f);
				//10. set jump = false
				jump = false;
		
		
		
				//13. Set the position of the player to normal
				transform.position = new Vector3 (-7f, -3f, 0f);
		
		}


		

	
		// Update is called once per frame
		void Update ()
		{


				
		if(score > 300 && Application.loadedLevelName == "level1" ){
			
			Application.LoadLevel(6);
			

			
		}

		if(score > 500 && Application.loadedLevelName == "level2" ){
			
			Application.LoadLevel(7);
			
			
			
		}


		if(score > 1000 && Application.loadedLevelName == "level3" ){
			
			Application.LoadLevel(8);
			
			
			
		}
		

				
				//3. if the mouse is clicked, set jump to true
				if (Input.GetMouseButtonDown (0)) {
						
						
						//5.jump the box
						StartCoroutine ("jumpBox");
						
					
				}


		if (Input.GetKey ("escape")) {
			Application.Quit();
		}

				
			
		}	
				

		
} 
