using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //�R�C����ǉ����Ă����鏈��
        drop._instance.addCoint();
        Destroy(collision.gameObject);
    }
}
