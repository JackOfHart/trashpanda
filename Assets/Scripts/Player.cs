using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Player : MonoBehaviour {
    
   
    public float Speed;
    public float RotateSpeed;
    public float jumpHeight;
    public Text score;

    public GameObject Cop;
    public GameObject tashCan;
    private GameObject HeldStuff;

    private float distanceToCop;
    private float distancetoDrop;
    private bool DropExist = false;

    private Vector3 CameraRotate = new Vector3(0f, 0f, 0f);
    private bool ControlsEnabled = true;
    private float itemsHeld = 0;
    private bool hasItems = true;
    private int trashOnTheGround = 0;

    // Use this for initialization
    void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {

        

        if (Input.GetKey(KeyCode.A) && ControlsEnabled == true)
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
            
            //Code below is for rotation mode
           //transform.Rotate(Vector3.down * RotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) && ControlsEnabled == true)
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;

            //Code below is for rotation mode
            //transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime) ;
        }


        if (Input.GetKey(KeyCode.W) && ControlsEnabled == true)
        {
            transform.localPosition += transform.forward * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) && ControlsEnabled == true) 
        {
          transform.localPosition += Vector3.back * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space) && ControlsEnabled == true)
        {
            transform.position += Vector3.up * jumpHeight * Time.deltaTime;
        }


        distanceToCop = Vector3.Distance(Cop.transform.position, this.transform.position);

        if(DropExist == true)
        {
            //distancetoDrop = Vector3.Distance(HeldStuff.transform.position, this.transform.position);

            if(distancetoDrop < 5 && Input.GetKey(KeyCode.LeftShift))
            {
                //DESTROYOBJECTHERE

                TrashCan.score += 10;
                score.text = "Score: " + TrashCan.score;

                trashOnTheGround--;
            }

        }
        
        if(trashOnTheGround <= 0)
        {
            DropExist = false;
        }


        //Spotted
        if (distanceToCop <= 2)
        {
            ControlsEnabled = false;

            

            

            this.transform.position += new Vector3(1, 1, 0) * Speed * Time.deltaTime;

            if(hasItems == true)
            {
                DropItems();
            }
            
        
        }


        else if(distanceToCop >4)
        {
            ControlsEnabled = true;
            hasItems = true;
        }


        print(trashOnTheGround);
    }

    void OnCollisionEnter(Collision col)
    {
        print("collide");
        if(col.gameObject.name == "Alleyway")
        {
            print("collide alley");
           //Camera.transform.rotation  = Quaternion.LookRotation(CameraRotate, new Vector3(0f,0f,0f));
           //Camera.transform.position = new Vector3(5.31f, 3, 0); 
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
                //GiveLocation

                Debug.Log(HeldStuff);

               

              

                

                TrashCan.score = 0;

                score.text = "Score: " + TrashCan.score;

                DropExist = true;

                trashOnTheGround++;
            }


        }

        hasItems = false;
    }
}
