/// <summary>
/// <두 수의 나눗셈>
/// [문제 설명]
/// 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에 1,000을 곱한 후 정수 부분을 return하도록 solution 함수를 완성해주세요.
/// [제한 사항]
/// 0 < num1 ≤ 100
/// 0 < num2 ≤ 100
/// </summary>

//#define sol_01
#define sol_02

#if sol_01
using System;

namespace Level_0
{
    public class Solution005
    {
        public int solution(int num1, int num2)
        {
            int answer = 0;
            float tmp = 0;

            if (num1 > 0 && num1 <= 100 && num2 > 0 && num2 <= 100)
            {
                tmp = (float)num1 / (float)num2;
                answer = (int)(tmp * 1000);
            }

            return answer;
        }
    }
}

#elif sol_02
using System;

namespace Level_0
{
    public class Solution005
    {
        public int solution(int num1, int num2)
        {
            int answer = 0;

            if (num1 > 0 && num1 <= 100 && num2 > 0 && num2 <= 100)
            {
                answer = num1 * 1000 / num2;
            }

            return answer;
        }
    }
}
#endif