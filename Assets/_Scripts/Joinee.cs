using UnityEngine;
using System.Collections;

public class Joinee : Photon.MonoBehaviour {
	
	public GameObject myCamera;

	void Start () {
		if(photonView.isMine){
			GetComponent<CharacterController>().enabled = true;
			GetComponent<OVRPlayerController>().enabled = true;
			GetComponent<OVRSceneSampleController>().enabled = true;
			GetComponent<OVRDebugInfo>().enabled = true;
			myCamera.SetActive(true);
		}
		else{

		}
		
	}

}
