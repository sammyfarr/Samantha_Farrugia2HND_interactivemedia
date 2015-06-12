using UnityEngine;
using System.Collections;

public class obstacleGeneratorController : MonoBehaviour
{

		//16. public gameobject variable for obstacle
		//public GameObject obstacle;
			
		//47. Implementing multiplae obstacle types
		public GameObject[] obstacles;	




		//17. declare a variable for the time gap
		float timeGap;


		//18. create a coroutine to generate obstacles
		IEnumerator generateObstacles ()
		{

				//19. the coroutine runs forever
				while (true) {
						//21. Random time gap
						timeGap = Random.Range (1f,2f);

						//49. obstacle chooser random number
			int obstacleChooser = (int)Mathf.Floor (Random.Range (0f,17f));
						
						//50. output the chosen obstacle on screen
						Debug.Log (obstacleChooser);
						//22. create an obstacle
						//48. choose the first item in the obstacles array
						Instantiate (obstacles[obstacleChooser],new Vector3(7f,-3f,0f),Quaternion.identity);


			//20. has a random time gap
			yield return new WaitForSeconds (timeGap);

		

			}

						
				}



		// Use this for initialization
		void Start ()
		{
			//23. start the coroutine that generates the obstacles immediately
			StartCoroutine ("generateObstacles");
		}




		
		
		}

