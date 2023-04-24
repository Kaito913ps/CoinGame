using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class drop : MonoBehaviour
{
    [SerializeField]
    private GameObject _coinPrefab;
    [SerializeField]
    private Text _text;
    [SerializeField]
    private GameObject _gameOver;
    //[SerializeField]
    //private Button button;

    [SerializeField ,Tooltip("持っているコイン枚数")]
    private int _numCoin;
    public static drop _instance;

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
    }
    void Start()
    {
        _gameOver.SetActive(false);
        //テキストにコイン枚数を記録
        _text.text = _numCoin.ToString();
    }

    /// <summary>
    /// コインをゲットした時の処理 
    /// </summary>
    public void addCoint()
    {
        _numCoin++;
        _text.text = _numCoin.ToString();
    }
   
    void Update()
    {
        //コインの枚数をチェック
        if(_numCoin == 0) 
        {
           
            _gameOver.SetActive(true);
            return;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            GameObject coin = Instantiate(_coinPrefab,this.transform);
            _numCoin--;
            //テキストにコイン枚数をセットする
            _text.text = _numCoin.ToString();
        }
    }
    
}
