using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollector : MonoBehaviour
{
    ///Otros Scripts
    [SerializeField]
    PlayerController playerCtl;

    //Variables de la moneda
    [SerializeField]
    int amountValue;
    [SerializeField]
    Collider col;
    [SerializeField]
    GameObject coinObj;

    //Variables de Rotacion de la moneda
    [SerializeField]
    Vector3 coinRotation;
    [SerializeField]
    float coinsSpeedRot = .125f;

    private void Update() 
    {
        /// Hacemos rotar la moneda
        coinObj.transform.Rotate(coinRotation * coinsSpeedRot);
    }

    private void OnTriggerEnter(Collider other)
    {
        /// Comprobamos si el GO que colisiona es el Player
        if (other.gameObject.tag == "Player")
        {
            playerCtl.coinsCollector += amountValue;
            col.gameObject.SetActive(false);
        }
    }
}
