using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    public Vector3 rotateSpeed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Codey")
        {
            gameObject.SetActive(false);
            Invoke("itemBoxRespawn", 5f);
        }
    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed*Time.deltaTime);
    }
}
