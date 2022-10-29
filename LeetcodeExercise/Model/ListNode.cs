namespace LeetcodeExerciseTest
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public int ToInt() =>
            val + (next is null ? 0 : next.ToInt() * 10);

        public static ListNode? Create(IEnumerable<int> souce) =>
            souce.Any() ?
                new(souce.FirstOrDefault(), Create(souce.Skip(1))) :
                default;

        public static ListNode? Create(int souce) =>
           souce >= 10 ?
               new(souce % 10, Create(souce / 10)) :
               new(souce);

        public override string? ToString()
        {
            return next is null ? $"{val}" : $"{val},{next}";
        }
    }
}
