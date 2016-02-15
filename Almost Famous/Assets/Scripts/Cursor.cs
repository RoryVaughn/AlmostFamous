using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {
    
   
    

	// Use this for initialization
	void Start () {
        
    }
        

    // Update is called once per frame
    void Update()
    {   
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x - 8, Input.mousePosition.y + 11, +10));
        if (Input.GetMouseButtonDown(0) == true)
        {
            GetComponent<AudioSource>().Play();
        }






    }
}
