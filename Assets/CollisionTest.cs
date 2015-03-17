using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour {


    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(string.Format("{0} has entered the trigger of {1}", collider.name, name));
    }
    void OnTriggerStay(Collider collider)
    {
        Debug.Log(string.Format("{0} is staying inside the trigger of {1}", collider.name, name));
    }
    void OnTriggerExit(Collider collider)
    {
        Debug.Log(string.Format("{0} has left the trigger of {1}", collider.name, name));
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(string.Format("{0} has collided with {1}", collision.collider.name, name));
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log(string.Format("{0} is colliding with {1}", collision.collider.name, name));
    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log(string.Format("{0} is no longer colliding with {1}", collision.collider.name, name));
    }
}
