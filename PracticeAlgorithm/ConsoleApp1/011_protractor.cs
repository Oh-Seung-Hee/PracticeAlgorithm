﻿/// <summary>
/// <각도기>
/// [문제 설명]
/// 각에서 0도 초과 90도 미만은 예각, 90도는 직각, 90도 초과 180도 미만은 둔각 180도는 평각으로 분류합니다. 각 angle이 매개변수로 주어질 때 예각일 때 1, 직각일 때 2, 둔각일 때 3, 평각일 때 4를 return하도록 solution 함수를 완성해주세요.
/// 예각 : 0 < angle < 90
/// 직각: angle = 90
/// 둔각: 90 < angle < 180
/// 평각: angle = 180
/// [제한 사항]
/// 0 < angle ≤ 180
/// angle은 정수입니다.
/// </summary>

#define sol_01
#define sol_02

using System;

namespace Level_0
{
    class Solution011
    {
#if sol_01
        public int solution(int angle)
        {
            int answer = 0;

            if (angle > 0 && angle < 90)
            {
                answer = 1;
            }
            else if (angle == 90)
            {
                answer = 2;
            }
            else if (angle > 90 && angle < 180)
            {
                answer = 3;
            }
            else if (angle == 180)
            {
                answer = 4;
            }

            return answer;
        }

#elif sol_02
        public int solution(int angle)
        {
            int answer = angle < 90 ? 1 : angle == 90 ? 2 : angle < 180 ? 3 : 4;
            return answer;
        }
#endif
    }
}