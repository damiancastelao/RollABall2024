using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // objeto que representa al player
    public GameObject player;
    // distancia entre la camara y el player
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
       /*if(Input.GetKey(KeyCode.A)) 
            transform.Translate(Vector3.left * 10.0f * Time.deltaTime);
        
          
        
        if(Input.GetKey(KeyCode.D))
            transform.Translate(-Vector3.forward * 10.0f * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime); */
    }


}
