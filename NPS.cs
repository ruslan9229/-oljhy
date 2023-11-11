using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    public int health = 5;

    public int level = 1;

    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print("������" +  health);
    }

    // Update is called once per frame
    void Update()
    {
        //C����� ���� Vector � ��������� ��� ������� NPS
        Vector3 newPosition = transform.position;

        //������ ������� NPS �� ��� z �������� �������� NPS � ������� ����� ������
        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
