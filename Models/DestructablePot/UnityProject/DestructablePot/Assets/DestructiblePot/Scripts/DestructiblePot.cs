using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// sample
/// </summary>

public class DestructiblePot : MonoBehaviour {

    public GameObject brokenPrefab;
    public AudioSource breakSound;

    private void OnCollisionEnter(Collision collision)
    {
        var brokenObject = Instantiate(brokenPrefab);
        brokenObject.transform.position = this.gameObject.transform.position;
        brokenObject.transform.rotation = this.gameObject.transform.rotation;
        brokenObject.transform.localScale = this.gameObject.transform.localScale;

        Destroy(this.gameObject);

        this.breakSound.Play();
    }
}
