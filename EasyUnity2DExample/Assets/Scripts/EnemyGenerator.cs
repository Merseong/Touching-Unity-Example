using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    // 싱글톤 패턴에서 외부에서 호출할때의 이름입니다.
    public static EnemyGenerator inst;

    // 적의 프리팹입니다.
    public GameObject enemy;
    // 적이 생성될 중심부터의 거리입니다.
    public float dist = 4;

    // Start보다 앞서 실행되는 함수입니다. 싱글톤 패턴을 간략하게 구현했습니다.
    private void Awake()
    {
        if (inst != null) Destroy(inst);
        inst = this;
        DontDestroyOnLoad(this);
    }

    // 적을 count만큼 무작위 위치에 생성하는 함수입니다.
    public void GenerateEnemy(int count)
    {
        for (int i = 0; i < count; ++i)
        {
            // 중심기준 원형에 배치할 것이므로, 0 ~ 2PI 내의 랜덤 값을 고릅니다.
            float rand = 2 * Mathf.PI * Random.Range(0f, 1f);

            // 원형에 적을 배치합니다.
            Instantiate(enemy, dist * new Vector3(Mathf.Cos(rand), Mathf.Sin(rand)), Quaternion.identity);
        }
    }
}
