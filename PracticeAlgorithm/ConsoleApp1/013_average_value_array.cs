/// <summary>
/// <배열의 평균값>
/// [문제 설명]
/// 정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.
/// [제한 사항]
/// 0 ≤ numbers의 원소 ≤ 1,000
/// 1 ≤ numbers의 길이 ≤ 100
/// 정답의 소수 부분이 .0 또는 .5인 경우만 입력으로 주어집니다.
/// </summary>

//#define sol_01
#define sol_02

using System;
using System.Linq;

namespace Level_0
{
    public class Solution013
    {
#if sol_01
        public double solution(int[] numbers)
        {
            double answer = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }

            return answer / numbers.Length;
        }

#elif sol_02
        public double solution(int[] numbers)
        {
            return numbers.Average();
        }
#endif
    }
}