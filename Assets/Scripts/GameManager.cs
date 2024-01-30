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
        
    }

    private void Update()
    {
        
    }

}
