using UnityEngine;

public class Swipe : MonoBehaviour
{
    public GameObject burnModel;
    public int wipesRequired = 2;
    public GameObject burnModel2;
    private int wipesCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sponge")) // ���������, ��� ����������� � �������� "�����"
        {
            wipesCount++;

            if (wipesCount >= wipesRequired)
            {
                ChangeBurnModel();
            }
        }
    }

    private void ChangeBurnModel()
    {
        if (burnModel != null)
        {
            burnModel.SetActive(false); // ��������� ������� ������ �����
            burnModel2.SetActive(true);
            Destroy(burnModel);
            // ����� �������� ��� ��� ��������� ������ ������ ����� ����� ���� ����������
        }
    }
}