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
    