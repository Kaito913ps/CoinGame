using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    /// <summary>
    /// �͂��󂯎���ē����鏈��
    /// </summary>
   public void Shoot(Vector3 power)
    {
        GetComponent<Rigidbody>().AddForce(power);
    }
}
