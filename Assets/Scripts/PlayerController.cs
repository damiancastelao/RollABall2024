using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // componente rigidbody de mi Player
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 0; 
    void Start()
    {
        rb = GetComponent <Rigidbody>();
        Debug.Log("Hola, soy un mensaje de debug en Start");
    }
    void OnMove (InputValue movementValue)
    {
        // recojo valores del InputSystem
        Vector2 movementVector = movementValue.Get<Vector2>(); 
        movementX = movementVector.x; 
        movementY = movementVector.y; 
        
    }

    // dar un salto con la tecla Fire (boton derecho del maouse)
    void OnFire(){
        Debug.Log("Hola, soy un mensaje de debug en OnFire");

        // aplico fuerza al rigidbody
        rb.AddForce(Vector3.up * 5.0f, ForceMode.Impulse); 
    }
    
    private void FixedUpdate() 
    {
        // dar un salto con la tecla espacio
        // if (Input.GetKeyDown(KeyCode.Space)) {
        //    OnFire();
        // }

        Vector3 movement = new Vector3 (speed*movementX, 0.0f , speed*movementY);

        // debug de ls valores de movimiento
        // Debug.Log("X: " + movementX + " Y: " + movementY + " Z: 0");
        
        rb.AddForce(movement); 
    }


}
