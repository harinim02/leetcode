public class Solution {
public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var dict = new Dictionary<int, IList<int>>();
            IList<IList<int>> result = new List<IList<int>>();
            for (var i = 0; i < groupSizes.Length; i++)
            {
                int current = groupSizes[i];
                dict.TryGetValue(current, out var list);
                if(list == null)
                {
                    list = new List<int>();
                }
                list.Add(i);
                if(list.Count == current)
                {
                    result.Add(list);
                    list = new List<int>();
                }
                dict[current] = list;
            }
            return result;
        }
}