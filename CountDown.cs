using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

    private float fullTime = 5;

	// Update is called once per frame
	void Update () 
    {

        // Make a countdown/time left  timer with Time.deltaTime principle.

        if(fullTime >= 0) // Checks if the timer isn't done yet.
        {
            fullTime -= Time.deltaTime; // Removes seconds per deltaTime
            Vector3 m_scale = this.gameObject.transform.localScale; // We create a new Vector3 for simplier things.
            m_scale.x -= Time.deltaTime; // Then we remove the x, by the miliseconds.
            this.gameObject.transform.localScale = m_scale; // Apply to the object

        }
        else
        {
            Destroy(this.gameObject); // Destroys after it reaches 0 or less.
        }

	} 

}
  
