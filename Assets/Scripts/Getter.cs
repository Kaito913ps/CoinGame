using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //コインを追加してあげる処理
        drop._instance.addCoint();
        Destroy(collision.gameObject);
    }
}
