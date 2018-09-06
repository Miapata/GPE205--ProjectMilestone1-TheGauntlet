using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public GameObject camera;
    public Transform launcher;
    public float rotateSpeed;
    public float moveSpeed;
	public float vertical;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotateCannon();
        Move();
    }


    void RotateCannon()
    {

    }


    void Move()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * rotateSpeed, Space.Self);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotateSpeed, Space.Self);

        }

		vertical= Input.GetAxis("Vertical");
    
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, vertical*moveSpeed*Time.deltaTime);
        }
		
    }
}
