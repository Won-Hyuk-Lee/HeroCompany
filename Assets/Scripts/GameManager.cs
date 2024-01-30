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
        
    }

    private void Update()
    {
        
    }

}
