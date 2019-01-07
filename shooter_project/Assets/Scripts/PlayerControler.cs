using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

    public VirtualJoystick joystick;
    public float moveSpeed;
    public float drag;
    public Vector3 MoveVector { set; get; }
    // Use this for initialization
    private Rigidbody thisRigidbody;
    private GameObject body;

    void Start () {
        thisRigidbody = gameObject.GetComponent<Rigidbody>();
        thisRigidbody.maxAngularVelocity = moveSpeed;
        thisRigidbody.drag = drag;
        // var a = GameObject.FindGameObjectsWithTag("Kam");
       // body.transform.parent = GameObject.FindGameObjectsWithTag("Kam");
    }
	private void Move()
    {
        thisRigidbody.AddForce((MoveVector * moveSpeed));
    }

	// Update is called once per frame
	void Update () {
        MoveVector = PoolInput();
        Move();
    }
    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;

        dir.x = joystick.Horizontal();
        dir.z = joystick.Vertical();
        if(dir.magnitude > 1)
        {
            dir.Normalize();
        }
        return dir;
    }
}
