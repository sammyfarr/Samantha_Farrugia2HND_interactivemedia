using UnityEngine;
using System.Collections;

public class obstacleController : MonoBehaviour
{
		//45. set a public variable for speed
		public float obstacleSpeed;
		
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				//14. move the obstacle to the left
				//46. replace the 6f with obstacleSpeed and set a different speed in the 2 levels
				transform.Translate (new Vector3 (-1f, 0f, 0f) * obstacleSpeed * Time.deltaTime);

				//15. if the x position is less than -7, delete the obstacle
				if (transform.position.x < -7) {
						Destroy (this.gameObject);
				}

		}
}
