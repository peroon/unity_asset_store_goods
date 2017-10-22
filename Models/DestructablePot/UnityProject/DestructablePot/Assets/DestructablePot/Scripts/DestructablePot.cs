using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructablePot : MonoBehaviour {

    public GameObject brokenPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        var brokenObject = Instantiate(brokenPrefab);
        brokenObject.transform.position = this.gameObject.transform.position;
        brokenObject.transform.rotation = this.gameObject.transform.rotation;

        Destroy(this.gameObject);    
    }
}
