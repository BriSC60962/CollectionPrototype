using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;



public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;



    private int count;


    // Start is called before the first frame update
    void Start()
    {

        count = 0;


        SetCountText();
        winTextObject.SetActive(false);

    }



    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 7)
        {
            winTextObject.SetActive(true);
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();

        }

    }

}
