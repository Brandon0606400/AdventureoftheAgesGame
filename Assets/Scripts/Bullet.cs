using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    // Calls the public score
    public Score scoreObject;
    public int collectableValue;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the thing that we collided with
        // is the player (aka has the player script)
        MovingEnemy movingEnemyScript = collision.collider.GetComponent<MovingEnemy>();

        // Only do something if the thing we ran into
        // was the player
        // aka playerScript is not null
        if (movingEnemyScript != null)
        {
            // We did hit the enemy
            // Kill them
            movingEnemyScript.killGuy();
            Destroy(gameObject);
            // Removes score when player kills an enemy
            scoreObject.AddScore(collectableValue);
        }
        else 
        {
            // Destroys the bullet when it hits a wall
            Destroy(gameObject);
        }
    }

}
