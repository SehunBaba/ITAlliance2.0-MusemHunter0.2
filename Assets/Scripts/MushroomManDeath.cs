using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomManDeath : MonoBehaviour {

     public  GameObject MushroomMan;	
	// Use this for initialization
	void Start () {
	}

    IEnumerator OnTriggerEnter(Collider other)
    {
        this.GetComponent<Collider>().enabled=false;
        GetComponent<MushroomManMove>().enabled = false;
        MushroomMan.transform.localScale = new Vector3(0, 0, 0.5f);
        MushroomMan.transform.localPosition = new Vector3(0, 0, 0.25f);
        yield return new WaitForSeconds(0.495F);
        MushroomMan.transform.localPosition = new Vector3 (0, -1000, 0);

    }
    // Update is called once per frame
    void Update () {
		
	}
}
