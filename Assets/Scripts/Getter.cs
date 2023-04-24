using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //ƒRƒCƒ“‚ğ’Ç‰Á‚µ‚Ä‚ ‚°‚éˆ—
        drop._instance.addCoint();
        Destroy(collision.gameObject);
    }
}
