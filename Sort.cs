using System;

namespace BeginerLearnProjrct {
    class Sort<T> where T : IComparable<T> {
        private static void Swap(ref T a, ref T b) {
            T c = a;
            a = b;
            b = c;
        }
        public static void BubbleSort(T[] arr) {
            for(int i = 0; i < arr.Length; i++) {
                for(int j = 0; j < arr.Length - 1; j++) {
                    if(arr[j].CompareTo(arr[j + 1]) > 0) {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        public static void InsertSort(T[] arr) {
            T min;
            int ind_min;
            for(int i = 0; i < arr.Length; i++) {
                min = arr[i];
                ind_min = i;
                for(int j = i + 1; j < arr.Length; j++) {
                    if(min.CompareTo(arr[j]) > 0) {
                        min = arr[j];
                        ind_min = j;
                    }
                }
                Swap(ref arr[i], ref arr[ind_min]);
            }
        }
        public static void GnomeSort(T[] arr) {
            int i = 0;
            while(i < arr.Length - 1) {
                if(arr[i].CompareTo(arr[i + 1]) > 0) {
                    Swap(ref arr[i], ref arr[i + 1]);
                    if(i != 0) {
                        i--;
                    }
                }
                else {
                    i++;
                }
            }
        }
    }
}
