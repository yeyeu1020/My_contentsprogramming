using UnityEngine;

public class TemperatureHeight : MonoBehaviour
{
    [Header("온도 설정")]
    public float temperature = 20.0f;  // 현재 온도
    public float maxHeight = 5.0f;     // 최대 높이

    private Transform myTransform;

    void Start()
    {
        myTransform = transform;

        // 시작 시 Parent Y 위치 0 고정
        Vector3 pos = myTransform.position;
        myTransform.position = new Vector3(pos.x, 0, pos.z);
    }

    void Update()
    {
        // 1. 높이 계산
        float height = Mathf.Clamp((temperature / 50f) * maxHeight, 0.1f, maxHeight);

        // 2. Scale 적용 (Y만)
        myTransform.localScale = new Vector3(1f, height, 1f);

        // 3. 바닥 고정: 월드 Y 좌표 = height/2
        Vector3 pos = myTransform.position;
        myTransform.position = new Vector3(pos.x, height / 2f, pos.z);

        // Debug
        Debug.Log("온도에 따른 높이 설정 완료: " + height);
    }
}
