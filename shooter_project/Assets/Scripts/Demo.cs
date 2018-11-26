using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour {

    List<string> touchInfos = new List<string>();
	
	// Update is called once per frame
	void Update () {
        touchInfos.Clear();

        for(int i=0;i<Input.touchCount;i++)
        {
            Touch touch = Input.GetTouch(i);
            string tmp = "Dotknienty #" + (i + 1) + " w " + touch.position.ToString();
            touchInfos.Add(tmp);
        }
		
	}

    void OnGUI()
    {
        foreach(string s in touchInfos)
        {
            GUILayout.Label(s);
        }
    }
}
