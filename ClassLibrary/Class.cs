﻿using System;

namespace ClassLibrary
{
	public static class Algorithm
	{


		public static void Input(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = i;
			}

			Random rand = new Random();
			for (int i = arr.Length - 1; i >= 1; i--)
			{
				int j = rand.Next(i + 1);

				int tmp = arr[j];
				arr[j] = arr[i];
				arr[i] = tmp;
			}

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}
		public static void Output(int[] arr)
		{
			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i]+" ");
			}
		}
		////////////////////////////////////////////////////////////////////////////////////////////////////
		public static void BubleSort(int[] arr)
		{
			for (int i = 0; i < arr.Length-1; i++)
			{
				for ( int j = 0; j < arr.Length-1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int tmp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = tmp;
					}
				}
			}
		}
		////////////////////
		public static void QuickSort(int[] array, int start, int end)
		{
			if (start >= end)
			{
				return;
			}
			int pivot = partition(array, start, end);
			QuickSort(array, start, pivot - 1);
			QuickSort(array, pivot + 1, end);
		}

		public static int partition(int[] array, int start, int end)
		{
			int temp;//swap helper
			int marker = start;//divides left and right subarrays
			for (int i = start; i < end; i++)
			{
				if (array[i] < array[end]) //array[end] is pivot
				{
					temp = array[marker]; // swap
					array[marker] = array[i];
					array[i] = temp;
					marker += 1;
				}
			}
			//put pivot(array[end]) between left and right subarrays
			temp = array[marker];
			array[marker] = array[end];
			array[end] = temp;
			return marker;
		}
		////////////////////
		public static void SelectionSort(int[] arr)
		{
			int min, temp;

			for (int i = 0; i < arr.Length - 1; i++)
			{
				min = i;

				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j] < arr[min])
					{
						min = j;
					}
				}

				if (min != i)
				{
					temp = arr[i];
					arr[i] = arr[min];
					arr[min] = temp;
				}
			}
		}
		////////////////////
		public static void InsertionSort(int[] arr)
		{
			for (int i = 1; i < arr.Length; i++)
			{
				int j;
				int buf = arr[i];
				for (j = i - 1; j >= 0; j--)
				{
					if (arr[j] < buf)
						break;

					arr[j + 1] = arr[j];
				}
				arr[j + 1] = buf;
			}
		}
		////////////////////////////////////////////////////////////////////////////////////////////////////
		public static void LinearSearch(int[] arr, int k)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == k) Console.WriteLine("такое число есть");
			}
		}
		
	}

	public class Key
	{
		string[] ListOfMethod = new string[]
		{
			"BubleSort",
			"QuickSort",
			"SelectionSort",
			"InsertionSort",
			"LinearSearch",
		};

		public void List()
		{
			for (int i = 0, k = 1; i < ListOfMethod.Length; i++, k++)
			{
				Console.WriteLine("{0}. {1}", k, ListOfMethod[i]);
			}
		}
	}

}
