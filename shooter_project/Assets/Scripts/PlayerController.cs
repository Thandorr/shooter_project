using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerController : MonoBehaviour  {

    public FixedJoystick MoveJoystick;
    public Joybutton JumpButton;
    public FixedTouchField TouchField;
   
    // Use this for initialization
    void Start () {
      
       
	}
	
	// Update is called once per frame
	void Update () {
        var fps = GetComponent<RigidbodyFirstPersonController>();

        fps.RunAxis = MoveJoystick.inputVector;
        fps.JumpAxis = JumpButton.Pressed;
        fps.mouseLook.LookAxis = TouchField.TouchDist;
    }
}
