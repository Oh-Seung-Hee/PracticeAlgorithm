using System;
/// <summary>
/// <짝수의 합>
/// [문제 설명]
/// 정수 n이 주어질 때, n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.
/// [제한 사항]
/// 0 < n ≤ 1000
/// </summary>
namespace Level_0
{
    public class Solution012
    {
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    answer += i;
                }
            }

            return answer;
        }
    }
}