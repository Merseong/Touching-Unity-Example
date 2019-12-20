# Touching-Unity-Example

2019 정보대학 SW 전공동아리 학술대회  
캣독 유니티 예시

유니티 버전: 2019.2.4f1

커밋 로그를 맨 아래부터 따라오시면 됩니다.  
변경사항이나 참고사항은 이 README.md에 작성됩니다.  
질문 환영 ^^

## 제작 과정

0. 유니티 프로젝트 만들기  
    2D 애셋을 사용할 것이므로, 2D로 만들었습니다.  

1. 애셋 추가하기  
    상단의 Window-Asset Store를 눌러 유니티 애셋 스토어를 엽니다.  
    2D Roguelike를 검색해 UNITY TECHNOLOGIES의 2D Roguelike를 다운로드 및 임포트합니다.  
    인터넷에서 배경으로 쓸 적당한 이미지도 찾아 넣습니다. (\Assets\Sprites\\)  

2. 에셋들 씬에 넣기  
    우선, Project탭의 Sprite폴더에 있는 Space-Texture-1을 드래그해 Scene탭에 놓습니다.  
    오른쪽의 Inspector탭에서 Transform에 우클릭해 Reset합니다. 이후, Position의 Z를 1로 바꿉니다. (백그라운드가 뒤에 놓이도록 만든것입니다.)  
    Hierarchy탭을 우클릭해 2D Object-Sprite를 만들고, Transform을 리셋합니다.  
    인스펙터에서 이름을 Player로 바꾸고, Sprite Renderer의 Sprite를 원하는 이미지로 바꿔줍니다. (옆의 동그란걸 누르면 됩니다.)
    하이어라키의 Main Camera를 누르고, 인스펙터에서 Background를 원하는 색으로 바꿉니다.  
    
3. 플레이어 만들기 및 이동 구현  
    Scripts폴더를 만들고, PlayerController스크립트를 만들고 작성합니다. (스크립트 주석 참고)  
    작성한 PlayerController스크립트를 드래그해 Player 게임오브젝트에 놓습니다.  
    위의 플레이버튼을 눌러 플레이해보면 WASD로 움직일 수 있습니다.  
    (선택) 플레이어의 인스펙터에서 PlayerController-Speed값을 조정해 이동속도를 바꿀 수 있습니다.  
    Main Camera를 드래그해 플레이어에 놓습니다. (이제 카메라가 플레이어와 같이 움직입니다.)  
    플레이어에서 Add Component를 눌러 Box Collider 2D와 Rigidbody 2D를 넣습니다.  
    Rigidbody2D에서 Gravity Scale을 0으로 바꿉니다.  
    (선택) 그림 주변에 다른 콜라이더 오브젝트들을 배치하고, Box Collider 2D의 Size를 조정하며 벽을 만들 수 있습니다. 이때, 플레이어의 Rigidbody 2D-Constraints-Freeze Rotation을 체크합니다.  

4. 총알 쏘기  
    씬에 Sprite를 만들고, Transform 리셋 후 Sprite에 아무거나 넣습니다.  
    Prefabs폴더를 만들고, 씬의 스프라이트를 드래그드롭으로 옮깁니다. (이걸로 Prefab을 만들수 있습니다.)  
    프리팹을 수정하면 프리팹에서 찍어내는 오브젝트들도 같게 만들 수 있습니다.  
    총알 프리팹에 Rigidbody2D와 BoxCollider2D를 넣고, BoxCollider에서 Is Trigger를 켜고, Rigidbody에서 Gravity Scale을 0으로 바꿉니다.
    Bullet스크립트를 만들어 프리팹에 넣습니다. (스크립트 주석 참고)  
    PlayerController스크립트를 수정합니다. (스크립트 주석 참고)  
    씬의 플레이어 오브젝트의 PlayerController-BulletPrefab에 총알 프리팹을 끌어다 놓습니다.  
    플레이해서 Game탭에서 클릭하면 그 방향으로 총알이 나갑니다. (엄청 많이)  
    (선택) PlayerController스크립트에서 총알 발사에 딜레이를 줄 수 있습니다. (스크립트 주석 참고)

5. 적 만들기  
    총알처럼 스프라이트를 만들고, 프리팹으로 만듭니다.  
    적 프리팹에 Rigidbody2D와 BoxCollider2D를 넣어주고, 중력을 제거하고 트리거를 켭니다.  
    MyEnemy스크립트를 만들어서 작성하고, 적 프리팹에 넣습니다. (스크립트 주석 참고)  
    플레이해보면, 쏜 총알이 적에 맞으면 적이 사라지고, 플레이어가 적에 맞으면 더이상 조작이 불가능해집니다.  

6. 적 제네레이터 만들기  
    이 게임에서는 적을 처치하면 2배로 늘어나게 되도록 만들려 합니다. (1마리를 잡으면 2마리가 나오게)  
    우선, EnemyGenerator 스크립트를 만들고 작성합니다. (스크립트 주석 참고)  
    씬에 EnemyGenerator라는 빈 게임오브젝트를 만들고, EnemyGenerator를 넣습니다.
    MyEnemy스크립트에서 죽을때마다 2마리씩 만들도록 수정합니다.  
    씬에 최초의 한마리를 배치하고 게임을 플레이해봅시다.  

7. 점수 시스템 및 UI  
    우선, 점수를 저장할 GameManager스크립트를 만들고 작성합니다. (스크립트 주석 참고)  
    씬에 빈 게임오브젝트를 만들고 GameManager스크립트를 넣습니다.  
    MyEnemy에서 적이 죽을때마다 점수를 올리도록 만듭니다.  
    씬에 UI-Text를 넣습니다. 생긴 Text 오브젝트의 위치, Alignment를 조정하고, 글씨 색과 크기를 조정합니다.  
    ScoreText스크립트를 작성해 텍스트 오브젝트에 넣습니다. (스크립트 주석 참고)  
    비슷한 방식으로 GameOver 텍스트도 만들어 GameManager에서 게임오버 관리시 뜨게 합니다.  
    재시작 버튼을 만들어 OnClick에서 처음으로 돌아갈 수 있게 만듭니다. (이부분에서 에셋의 코드에서 오류가 나지만 무시해도 됩니다.)  

8. (선택) 추가기능들  
    1. 하이스코어 저장 기능 (GameManager:23~26줄, 32~39, 49~54, ScoreText:21~23)
    2. 커서방향/이동방향으로 바라보기 (PlayerController:31~36, MyEnemy:23~30)
    3. 캐릭터 애니메이션 (PlayerController:16~22, 53)
    4. 마우스 커서 (GameManager:27~28, 41~42)
    5. 파티클 (GameManager:29~30, MyEnemy:40~41, 54~55)

9. 빌드하기  
    유니티 상단의 File-Build Setting을 엽니다.  
    빌드할 씬, 플랫폼(보통 맨위의 Standalone)을 선택하고 Build And Run을 누릅니다.  
    자유롭게 플레이합니다!  
