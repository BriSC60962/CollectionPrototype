using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    public GameObject ChestOpens;
    public GameObject ChestClose;
    public GameObject Gem;
    public GameObject PlayerKeyGold;
    private void OnTriggerEnter(Collider other)
    {
        ChestOpens.SetActive(true);
        ChestClose.SetActive(false);
        Gem.SetActive(true);
        gameObject.SetActive(false);
        PlayerKeyGold.SetActive(false);
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
