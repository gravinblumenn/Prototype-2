using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    //These are Variables
    private float horizontalInput;
    private float speed = 10.0f;
    private float xRange = 17;
    public GameObject projectilePreFab;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //shoots Steak PreFab
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePreFab, transform.position, projectilePreFab.transform.rotation);
            
        }
        //Keeps PLayer within a visible range
        if  (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        //Player movement on the x-axis
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
