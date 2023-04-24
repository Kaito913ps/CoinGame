using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField, Tooltip("コインを生成するようにする")]
    private GameObject _coinPrefab;
    [Tooltip("コインをカウントするための変数")]
    private int _numCoin;
    [SerializeField, Tooltip("コイン最大何枚生成するか")]
    private int _maxCoin;
    [SerializeField, Tooltip("生成する場所")]
    GameObject[] _spwnPoint;
    [Tooltip("生成時での経過時間")]
    private float _time;

    void Update()
    {
        //条件でコイン生成するようにする
        if(_numCoin < _maxCoin)
        {
            GameObject radomPoint = _spwnPoint[Random.Range(0, _spwnPoint.Length)];
            Instantiate(_coinPrefab, radomPoint.transform.position,Quaternion.identity);
            _numCoin++;
        }
        
    }
}
