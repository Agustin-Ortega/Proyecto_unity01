using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[HideInInspector] // es un modificador para no modificar esta variable desde el ide
    [Range(0,80), SerializeField]  // serializado para q proteger la prop y permitir editarla
    [Tooltip("#Velocidad lineal del Vehiculo")] // placeholder de la prop en el ide
    private float velocidad = 5f;

    [Range(0,50), SerializeField]
    [Tooltip("Velocidad de giro del vehiculo")]
    private float velocidadGiro =5f;

    
    private float horizontalInput;
    private float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // valores definidos en proyect manager/ input manager
        this.horizontalInput = Input.GetAxis("Horizontal");
        this.verticalInput = Input.GetAxis("Vertical");
        
        // se ejecuta a 60fps por segundo
        //this.transform.Translate(0,0,1);
        // espacio  =  velocidad * tiempo * (direccion)
        transform.Translate(velocidad*Time.deltaTime*Vector3.forward * verticalInput); // LINEAL
        transform.Rotate(velocidadGiro* Time.deltaTime*Vector3.up* horizontalInput); // HORIZONTAL
        
        
    }
}
