using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    /// <summary>
    /// 力を受け取って投げる処理
    /// </summary>
   public void Shoot(Vector3 power)
    {
        GetComponent<Rigidbody>().AddForce(power);
    }
}
