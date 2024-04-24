namespace QuickSort
{
	public class Program : Sort
	{
		static void Main(string[] args)
		{
			//Mostra array original
			int[] nums = { 8, 875, 7, 9, 764, 55 };
			Console.WriteLine("Array original:");
			foreach (int i in nums)
			{
				Console.WriteLine(i);
			}

			//Passando array não ordenado, ponteiro esquerdo e ponteiro direito
			Ordena(nums, 0, nums.Length - 1);

			Console.WriteLine("Array ordenado:");

			foreach (int i in nums)
			{
				Console.WriteLine(i);
			}
		}
	}
}
