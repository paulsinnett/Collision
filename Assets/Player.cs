using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    CharacterController controller;

	// Use this for initialization
	void Start () {

        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
	
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime);
	}

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Enemy"))
        {
            //Destroy(hit.gameObject);
            hit.gameObject.AddComponent<Rigidbody>();
        }
    }
}
