using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    /// <summary>
    /// —Í‚ğó‚¯æ‚Á‚Ä“Š‚°‚éˆ—
    /// </summary>
   public void Shoot(Vector3 power)
    {
        GetComponent<Rigidbody>().AddForce(power);
    }
}
