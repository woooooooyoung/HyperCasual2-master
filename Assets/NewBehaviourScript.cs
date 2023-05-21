using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Project Settings - Player - Android Settings - Orientation - Default Orientation
    // Auto Rotation : 핸드폰 회전시 적용
    // Portrait : 세로 전용
    // Landscape : 가로 전용

    // Pixels Per Unit : 1m에 몇 pixels가 있는지를 설정
    // 최적화를 위해 기본적으로 2의 배수르 써주는게 좋음
    // 2의 배수가 아니면 딱 떨어지지 않기 때문에 연산이 많이 들어감
    // 2의 배수로 설정하면 비트쉬프트 연산가지고 바로 추출할 수 있음

    // 게임영역 따로 UI영역 따로 잡힐 시 캔버스의 오버레이 영역을 카메라로 두고 메인카메라를 넣어준다.
    // 배경 이미지를 UI를 통해 넣어줄땐 전역을 앵커로 잡아주고 다 0으로 만들면 화면에 꽉찬다.

    // Sorting Layer : 레이어의 순서를 결정, 새로 만들때 위에 있을수록 뒤에 그려짐 아래에 있을수록 앞에 그려짐
    // Order In Layer : 같은 레이어 중에서도 먼저 그려질 우선순위 높을수록 먼저보임

    // Input를 만들때 모바일에는 키보드 마우스가 없으니 Press[Touchscreen]으로 만들어준다
    // 물리설정 Project Settings - Physics 
    // 기본적으로 지구의 중력가속도인 -9.81사용
    // 게임의 중력일때 보통 -25 ~ 30정도를 써준다.(게임의 재미를 위해)
    // 2D게임과 3D게임은 구조가 다름
    
    // Adaptive Performance : 3D게임에서 어디서 과부화가 되는지 체크하는 용도
}
