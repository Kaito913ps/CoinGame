using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    private Rigidbody _rb;
    [Tooltip("プッシャーのスタート位置")]
    private Vector3 _startPos;
    void Start()
    {
        //リジットボディを取得
        _rb = GetComponent<Rigidbody>();
        //プッシャーのスタート位置を取得
        _startPos = transform.position;
    }

    private void FixedUpdate()
    {
        //プッシャーを動かす
        _rb.MovePosition(new Vector3(_startPos.x, _startPos.y, _startPos.z + Mathf.Sin(Time.time * 2)));
    }
}
