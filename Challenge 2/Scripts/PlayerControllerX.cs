using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogCoolDown = 1.0f;
    private float dogTimer;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // updates the timer 
        dogTimer += Time.deltaTime;

        // On spacebar press, send dog , check to make time duration has been satisfied
        if (Input.GetKeyDown(KeyCode.Space) && dogTimer > dogCoolDown)
        {
            
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // reset the dog timer.
            dogTimer = 0.0f;
        }
    }
}
