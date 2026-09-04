using UnityEngine;

public class RotateFast : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new UnityEngine.Vector3(150, 1000, 100) * Time.deltaTime); 
        //transform.rotate means to make this thing move around its own axis, using vector 3 will have 3 parameters for the x, y, and z access
        //bc my parameters are integers these are static speeds, and Time.deltaTime is the change over time from the last frame
    }
}
