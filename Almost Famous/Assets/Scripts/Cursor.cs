using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {
    public GameObject Scope;
   
    public float distance = 1.0f;

	// Use this for initialization
	void Start () {
        
    }
        

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosistion = Input.mousePosition;
        mousePosistion.z = distance;
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       
	

            
        


    }
}
