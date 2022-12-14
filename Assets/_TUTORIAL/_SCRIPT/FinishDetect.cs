using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishDetect : MonoBehaviour
{
    //Otros Scripts
    [SerializeField]
    PlayerController playerCtl;

    [SerializeField]
    GameObject winCanvas;
    [SerializeField]
    TextMeshProUGUI textTimer;
    [SerializeField]
    TextMeshProUGUI textCoins;

    [SerializeField]
    float timeRecord;
    [SerializeField]
    bool isPlay;
    
    void Awake()
    {
        isPlay = true;
    }
    void Update()
    {
        if (isPlay)
        {
            timeRecord += Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("PLAYER");
            winCanvas.SetActive(true);
            other.GetComponent<PlayerController>().enabled = false;
            isPlay = false;
            textTimer.text = timeRecord.ToString("f0") + "   segundos";
            textCoins.text = playerCtl.coinsCollector.ToString() + "   Monedas";
        }
    }
}
