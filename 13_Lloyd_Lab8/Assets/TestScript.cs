using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject scoreText;
    float spaceBarCounter=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: "+spaceBarCounter;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceBarCounter++;

        }
    }
}
