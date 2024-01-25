using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region SingleTon
    private static GameManager instance = null;

    public static GameManager Inst
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

                if (instance == null)
                {
                    instance = new GameObject().AddComponent<GameManager>();
                }
            }

            return instance;
        }
    }
    #endregion

    /*
    #region INFO
    [Header("Images")]
    [SerializeField] private Sprite[] Crystals = null;
    #endregion
    */

    #region ��������
    public int money = 0;
    public int earnMoneyGradeA = 1;

    public bool grade1 = true;

    #endregion

    #region �ڷ�ƾ
    IEnumerator EarnMoneyCoroutineA()
    {
        while (true)
        {
            // Wait for one second
            yield return new WaitForSeconds(1.0f);

            // Earn money
            money += earnMoneyGradeA;
        }
    }
    #endregion

    private void Awake()
    {
        //�񵿱� �ε� �õ�

        //�ϳ��� �̱��� �ν��Ͻ� ���� <- �̰� ��¥ �ʿ����� ���Ἲ üũ �� ��

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // ��, �� ȯ�� ����

        // �޾ƿ� ���� ������ ����

        // 

    }

    private void Start()
    {
        StartCoroutine(EarnMoneyCoroutineA());
    }

    private void Update()
    {
        //UI�� �� ������Ʈ ǥ��
        Debug.Log("�̴ϰ��");
    }

}
