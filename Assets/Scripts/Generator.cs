using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField, Tooltip("�R�C���𐶐�����悤�ɂ���")]
    private GameObject _coinPrefab;
    [Tooltip("�R�C�����J�E���g���邽�߂̕ϐ�")]
    private int _numCoin;
    [SerializeField, Tooltip("�R�C���ő剽���������邩")]
    private int _maxCoin;
    [SerializeField, Tooltip("��������ꏊ")]
    GameObject[] _spwnPoint;
    [Tooltip("�������ł̌o�ߎ���")]
    private float _time;

    void Update()
    {
        //�����ŃR�C����������悤�ɂ���
        if(_numCoin < _maxCoin)
        {
            GameObject radomPoint = _spwnPoint[Random.Range(0, _spwnPoint.Length)];
            Instantiate(_coinPrefab, radomPoint.transform.position,Quaternion.identity);
            _numCoin++;
        }
        
    }
}
