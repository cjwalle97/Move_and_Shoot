using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerController : NetworkBehaviour
{
    private float speed = 0.1f;

	void Update ()
    {
        if(!isLocalPlayer)
        {
            return;
        }
        var x = Input.GetAxis("Horizontal") * speed;
        var z = Input.GetAxis("Vertical") * speed;
        transform.position += new Vector3(x, 0, z);
	}
}
