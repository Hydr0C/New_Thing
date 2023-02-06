using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    private Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        if (!TryGetComponent<Rigidbody>(out rbody))
        {
            Debug.LogError("No RigidBody bro");
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") && gameObject.CompareTag("Left"))
        {
           
            rbody.velocity = Vector3.right * speed;
        }
        else if (Input.GetKey("s") && gameObject.CompareTag("Left"))
        {
            rbody.velocity = -Vector3.right * speed;
        }
        else
        {
            rbody.velocity = Vector3.zero;
        }

        /*
        if (Input.GetKey(KeyCode.UpArrow) && gameObject.CompareTag("Right"))
        {
            rbody.velocity = Vector3.right * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && gameObject.CompareTag("Right"))
        {
            rbody.velocity = -Vector3.right * speed;
        }
        else
        {
            rbody.velocity = Vector3.zero;
        }*/
        
    }
}
