/// <summary>
/// <두 수의 나눗셈>
/// [문제 설명]
/// 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에 1,000을 곱한 후 정수 부분을 return 하도록 soltuion 함수를 완성해주세요.
/// [제한 사항]
/// 0 < num1 ≤ 100
/// 0 < num2 ≤ 100
/// </summary>

//#define sol_01
#define sol_02

using System;

namespace Level_0
{
    public class Solution010
    {
#if sol_01
        public int solution(int num1, int num2)
        {
            int answer = 0;
            return answer = num1 * 1000 / num2;
        }

#elif sol_02
        public int solution(int num1, int num2)
        {
            int answer = 0;
            return answer = (int)((float)num1 / num2 * 1000);
        }
#endif
    }
}