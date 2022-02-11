using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    //OnTrigerEnter se llamará automaticamente cuando un objeto físico este dentro del trigger del Game Object
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            //El animal choca contra un proyectil
            Destroy(this.gameObject); //Destruye el animal
            Destroy(other.gameObject); //Destruye lo otro 
        }
    }
}
