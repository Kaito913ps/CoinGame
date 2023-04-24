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

    [SerializeField ,Tooltip("�����Ă���R�C������")]
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
        //�e�L�X�g�ɃR�C���������L�^
        _text.text = _numCoin.ToString();
    }

    /// <summary>
    /// �R�C�����Q�b�g�������̏��� 
    /// </summary>
    public void addCoint()
    {
        _numCoin++;
        _text.text = _numCoin.ToString();
    }
   
    void Update()
    {
        //�R�C���̖������`�F�b�N
        if(_numCoin == 0) 
        {
           
            _gameOver.SetActive(true);
            return;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            GameObject coin = Instantiate(_coinPrefab,this.transform);
            _numCoin--;
            //�e�L�X�g�ɃR�C���������Z�b�g����
            _text.text = _numCoin.ToString();
        }
    }
    
}
