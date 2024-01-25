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

    #region 지역변수
    public int money = 0;
    public int earnMoneyGradeA = 1;

    public bool grade1 = true;

    #endregion

    #region 코루틴
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
        //비동기 로딩 시도

        //하나의 싱글턴 인스턴스 보장 <- 이거 진짜 필요한지 무결성 체크 좀 ㄱ

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // 맵, 밑 환경 생성

        // 받아온 게임 데이터 적용

        // 

    }

    private void Start()
    {
        StartCoroutine(EarnMoneyCoroutineA());
    }

    private void Update()
    {
        //UI에 돈 업데이트 표시
        Debug.Log("미니고냐");
    }

}
