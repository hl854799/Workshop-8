using UnityEngine;
using System.Collections;

public class SwarmManager : MonoBehaviour {

    // External parameters/variables
    public GameObject enemyTemplate;
    public int enemyRows;
    public int enemyCols;
    public float enemySpacing;
    public float stepSize;
    public float stepTime;
    public float maxXDeviation; // Largest/smallest X-coordinate the edge of the swarm should reach

    // Internal parameters/variables
    private float stepCountdown;

    // Use this for initialization
    void Start () {
        GenerateSwarm();

        // Initial parameters
        this.stepCountdown = this.stepTime;
        this.transform.localPosition = Vector3.left * maxXDeviation; // Start at far left
	}
	
	// Update is called once per frame
	void Update () {
        this.stepCountdown -= Time.deltaTime;
        if (this.stepCountdown < 0.0f)
        {
            // Perform a single step to move the swarm across (or down)
            // Then reset the timer to periodically perform such steps
            this.StepSwarm();
            this.stepCountdown = this.stepTime;
        }
    }

    // Method to automatically generate swarm of enemies based on the set public attributes
    private void GenerateSwarm()
    {
        // Task 4b ...
    }

    // Method to step a swarm across the screen (or down & reverse when it reaches the edge)
    private void StepSwarm()
    {
        // Task 4c ...
    }
}
