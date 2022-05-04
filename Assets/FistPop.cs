using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistPop : MonoBehaviour
{
   public GameObject myPrefab;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed");


         Vector3 playerposition = GameObject.FindGameObjectWithTag("Player").transform.position;

         playerposition.x += 10;
         playerposition.y += 9;
         playerposition.z += 8;


            Instantiate(myPrefab, playerposition, Quaternion.identity);


   

        }


        if(Input.GetKeyDown(KeyCode.Escape)){
                Application.Quit();
        }
    }
}
