using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    private Rigidbody _rb;
    [Tooltip("�v�b�V���[�̃X�^�[�g�ʒu")]
    private Vector3 _startPos;
    void Start()
    {
        //���W�b�g�{�f�B���擾
        _rb = GetComponent<Rigidbody>();
        //�v�b�V���[�̃X�^�[�g�ʒu���擾
        _startPos = transform.position;
    }

    private void FixedUpdate()
    {
        //�v�b�V���[�𓮂���
        _rb.MovePosition(new Vector3(_startPos.x, _startPos.y, _startPos.z + Mathf.Sin(Time.time * 2)));
    }
}
