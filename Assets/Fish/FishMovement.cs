using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class FishMovement : MonoBehaviour
{
    public Rigidbody2D body;
    private float multiplier;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        multiplier = UnityEngine.Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
        body.linearVelocity = new Vector2(5*multiplier, 0);
        if (transform.position.x > 10 || transform.position.x <-10) // or whatever your boundary is
        {
            Destroy(gameObject); // remove fish if it goes off-screen
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check it's the player (or whatever should collect the fish)
        if (other.CompareTag("Hook"))
        {
            //ScoreManager.Instance.AddScore(1); // or however you track score
            Destroy(gameObject); // optional: remove fish on collection
            ScoreManager.Instance.AddScore(1);
            Debug.Log("Fish collected!"); // for testing purpose
        }
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject); // remove fish if it hits the boundary
            ScoreManager.Instance.RemoveLives();
            Debug.Log("Fish missed! Lives remaining: " + ScoreManager.Instance.lives); // for testing purposes
        }
    }
}
