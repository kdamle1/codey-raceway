using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;

    public int randomNumberInList;

    public GameObject chosenPowerup;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && chosenPowerup)
        {
            gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
            Instantiate(chosenPowerup, transform.position + transform.forward * 3, transform.rotation);
            chosenPowerup = null;
        }
    }
}
