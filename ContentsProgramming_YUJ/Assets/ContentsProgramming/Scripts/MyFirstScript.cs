using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // 다양한 타입의 변수 선언
    public int playerHealth = 100;        // 플레이어 체력
    public int playerLevel = 1;           // 플레이어 레벨
    public float walkSpeed = 5.0f;        // 걸음 속도
    public string playerName = "김철수";   // 플레이어 이름
    public bool canJump = true;

    // Start는 게임 시작할 때 한 번 실행됩니다
    void Start()
    {
        Debug.Log("게임이 시작되었습니다!");
        Debug.Log("플레이어 이름: " + playerName);
        Debug.Log("플레이어 레벨: " + playerLevel);
        Debug.Log("플레이어 체력; " + playerHealth);
        Debug.Log("걸음 속도: " + walkSpeed);
        Debug.Log("점프 가능 여부: " + canJump);

    }
}
