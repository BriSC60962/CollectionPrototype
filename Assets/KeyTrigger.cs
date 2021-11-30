using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour
{
    public GameObject PlayerKeyGold;
    public GameObject ChestTrig;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);

        PlayerKeyGold.SetActive(true);
        ChestTrig.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
