using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {
    
   
    public float Speed;
    public float RotateSpeed;
    public float jumpHeight;

    

    private Vector3 CameraRotate = new Vector3(0f, 0f, 0f);
    // Use this for initialization
    void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {

        

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
            
            //Code below is for rotation mode
           //transform.Rotate(Vector3.down * RotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;

            //Code below is for rotation mode
            //transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime) ;
        }


        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
          transform.localPosition += Vector3.back * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * jumpHeight * Time.deltaTime;
        }

        



    }

    void OnCollisionEnter(Collision col)
    {
        print("collide");
        if(col.gameObject.name == "Alleyway")
        {
            print("collide alley");
           //Camera.transform.rotation  = Quaternion.LookRotation(CameraRotate, new Vector3(0f,0f,0f));
           // Camera.transform.position = new Vector3(5.31f, 3, 0); 
        }

    }
}
