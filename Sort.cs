using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginerLearnProjrct {
    class Sort<T> where T: IComparable<T> {
        private static  void Swap(ref T a, ref T b) {
            T c = a;
            a = b;
            b = c;
        }
        public static void BubbleSort(T [] arr) { 
            for(int i = 0;i < arr.Length; i++) {
                for(int j = 0;j < arr.Length - 1; j++) {
                    if(arr[j].CompareTo(arr[j + 1]) > 0) {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}
