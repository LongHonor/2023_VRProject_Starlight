using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMovement : MonoBehaviour
{
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        // ���콺 ��ġ�� ���� ����� ��ȯ
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // �巡�� ��� ������Ʈ�� ���콺 ��ġ�� �̵�
        transform.position = mousePos + offset;
    }

    private void OnMouseDown()
    {
        // ���콺 Ŭ�� �� �Ÿ� ������ ���
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
