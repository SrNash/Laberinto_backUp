using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBladesTrap : MonoBehaviour
{
    //Variables del child del GO vacío
    [SerializeField]
    GameObject bladesObj;
    //Vector3 de posicionamiento A-B
    [SerializeField]
    Vector3 a_Pos;
    [SerializeField]
    Vector3 b_Pos;

    //Variable de control de velocidad de desplazamiento
    [SerializeField]
    float smoothSpeed = .125f;

    //Booleans de control
    [SerializeField]
    bool initPos = true, finalPos = false;

    // Update is called once per frame
    void Update()
    {
        ///<summary>
        /// Procederemos a comprobar mediante las variables booleans
        /// el posicionamiento actual de nuestra trampa,
        /// para determinar así su siguiente desplazamiento.
        ///</summary>
        if (initPos)
        {
            bladesObj.transform.Translate(b_Pos * smoothSpeed);
            if (bladesObj.transform.localPosition.z >= b_Pos.z)
            {
                /// Cambiaremos las booleans de valor.
                finalPos = true;
                initPos = false;
            }
        }else if (finalPos)
        {
            bladesObj.transform.Translate(a_Pos * smoothSpeed);
            if (bladesObj.transform.localPosition.z <= a_Pos.z)
            {
                /// Cambiaremos las booleans de valor.
                finalPos = false;
                initPos = true;
            }
        }
    }
}
