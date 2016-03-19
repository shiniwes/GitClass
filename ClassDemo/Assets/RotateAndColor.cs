using UnityEngine;
using System.Collections;

public class RotateAndColor : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
        StartCoroutine("RotateColor");
	}

    IEnumerator RotateColor()
    {
        yield return new WaitForSeconds(6.283185f);
        transform.Rotate(45.0f,-10.0f,15.40f);
        GetComponent<MeshRenderer>().material.color = new Color(255,128,0,1);
    }
}
