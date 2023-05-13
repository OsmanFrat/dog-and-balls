using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //The number of frames that have elapsed since the last Space key press
    private int frameCount = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if at least 5 seconds have passed since the last space key press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && frameCount > 76)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //Reset frameCount when we send a dog
            frameCount = 0;
        }

        //increases frameCount by 1 once per frame
        frameCount++;
    }
}
