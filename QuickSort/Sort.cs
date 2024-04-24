using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
	public abstract class Sort
	{
		public static void Ordena(int[] nums, int esquerda, int direita)
		{
			if (esquerda < direita)
			{
				int pivot = SepararArray(nums, esquerda, direita);

				Ordena(nums, esquerda, pivot - 1);
				Ordena(nums, esquerda + 1, direita);
			}
		}

		public static int SepararArray(int[] nums, int esquerda, int direita)
		{
			int pivot = nums[direita];
			int i = esquerda - 1;

			for (int j = esquerda; j < direita; j++)
			{
				if (nums[j] <= pivot)
				{
					i++;
					int tempVariable = nums[i];
					nums[i] = nums[j];
					nums[j] = tempVariable;
				}
			}

			int tempVariable1 = nums[i + 1];
			nums[i + 1] = nums[direita];
			nums[direita] = tempVariable1;

			return i + 1;
		}
	}
}
