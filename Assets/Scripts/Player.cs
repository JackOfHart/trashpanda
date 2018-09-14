using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {
    
   
    public float Speed;
    public float RotateSpeed;
    public float jumpHeight;

<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject Cop;
    public GameObject tashCan;
    public GameObject HeldStuff;

    private float distanceToCop;
    private float distancetoDrop;
    private bool DropExist = false;
=======
    
>>>>>>> 29cceedd2d50863b99415b894f6e1861a58d6277
=======
    
>>>>>>> 29cceedd2d50863b99415b894f6e1861a58d6277

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

        
<<<<<<< HEAD


=======


>>>>>>> 29cceedd2d50863b99415b894f6e1861a58d6277

    }

    void OnCollisionEnter(Collision col)
    {
        print("collide");
        if(col.gameObject.name == "Alleyway")
        {
            print("collide alley");
           //Camera.transform.rotation  = Quaternion.LookRotation(CameraRotate, new Vector3(0f,0f,0f));
<<<<<<< HEAD
<<<<<<< HEAD
           //Camera.transform.position = new Vector3(5.31f, 3, 0); 
        }

        if (col.gameObject.tag == "Trash" && Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            DestroyObject(col.gameObject);
        }

    }

    void DropItems()
    {
        

        int i = 0;

        itemsHeld = (TrashCan.score / 10);

        Debug.Log(itemsHeld);

        if(TrashCan.score > 0)
        {
            for (i = 0; i < itemsHeld; i++)
            {
                //SpawnPrefab

                Instantiate(HeldStuff, this.transform.position, Quaternion.identity);

                //GiveLocation

                Debug.Log(HeldStuff);
                    
                TrashCan.score = 0;

                score.text = "Score: " + TrashCan.score;

                DropExist = true;

                trashOnTheGround++;
            }


=======
           // Camera.transform.position = new Vector3(5.31f, 3, 0); 
>>>>>>> 29cceedd2d50863b99415b894f6e1861a58d6277
=======
           // Camera.transform.position = new Vector3(5.31f, 3, 0); 
>>>>>>> 29cceedd2d50863b99415b894f6e1861a58d6277
        }

    }
}
