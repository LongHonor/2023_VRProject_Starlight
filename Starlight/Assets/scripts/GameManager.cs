using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        puzzle.Instance.OpenDrawer();
    }

    // Update is called once per frame
    void Update()
    {
        //if (!isGameOver) Debug.Log(isGameOver);
        //isGameOver = �̴Ͼ��ĸŴ����� ���ӿ��� ��ȣ�� �����ϴ� �Լ�
        
    }
}
