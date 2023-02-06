using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
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
        else 
        {
            rbody.AddForce(0, 0, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
