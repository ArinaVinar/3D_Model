using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class erunda : MonoBehaviour
{
    public Dropdown dropdown1 = GameObject.Find("Point_A").GetComponent<Dropdown>();
    public Dropdown dropdown2 = GameObject.Find("Point_B").GetComponent<Dropdown>();
    //public GameObject eee = GameObject.Find("1601");
    //public DropdownField

    private List<GameObject> auditoriums = new List<GameObject>();
    private GameObject object1601;
    private GameObject object1602;
    private GameObject object1604;
    private GameObject object1606;
    private GameObject object1608;
    private GameObject object1610;
    private GameObject object1612;
    private GameObject object1614;


    void Start()
    {
        // �������� ������� �������� ��� ������ ����������� �����������
        object1601 = GameObject.Find("1601");
        object1602 = GameObject.Find("1602");
        object1604 = GameObject.Find("1604");
        object1606 = GameObject.Find("1606");
        object1608 = GameObject.Find("1608");
        object1610 = GameObject.Find("1610");
        object1612 = GameObject.Find("1612");
        object1614 = GameObject.Find("1614");

        auditoriums.Add(object1601);
        auditoriums.Add(object1602);
        auditoriums.Add(object1604);
        auditoriums.Add(object1606);
        auditoriums.Add(object1610);
        auditoriums.Add(object1612);
        auditoriums.Add(object1614);


        // ������������� �� ������� ��������� ��������� �������� � dropdown-�������
        dropdown1.onValueChanged.AddListener(OnDropdown1ValueChanged);
        dropdown2.onValueChanged.AddListener(OnDropdown2ValueChanged);
    }

    void OnDropdown1ValueChanged(int value)
    {
        CalculateDistance(value);
    }

    void OnDropdown2ValueChanged(int value)
    {
        CalculateDistance(value);
    }

    void CalculateDistance(int index)
    {
        if (object1601 != null && object1602 != null
            && object1604 != null && object1606 != null
            && object1608 != null && object1610 != null
            && object1612 != null && object1614 != null)
        {
            // ���������� ��������� ����� ���������
            float distance = Vector3.Distance(auditoriums[index].transform.position, object1601.transform.position);

            // ����� ��������� � �������
            Debug.Log("Distance: " + distance);
        }
    }
}
