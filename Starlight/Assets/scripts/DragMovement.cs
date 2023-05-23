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
        // 마우스 위치를 게임 월드로 변환
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // 드래그 대상 오브젝트를 마우스 위치로 이동
        transform.position = mousePos + offset;
    }

    private void OnMouseDown()
    {
        // 마우스 클릭 시 거리 오프셋 계산
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
