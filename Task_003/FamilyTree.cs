using System.Collections;

namespace Task_003
{
    internal class FamilyTree<T> : ICollection<T>
    {
        private T[] arr = new T[default];
        private int count = default;

        int ICollection<T>.Count 
            => count;

        bool ICollection<T>.IsReadOnly 
            => false;

        void ICollection<T>.Add(T item)
        {
            Array.Resize<T>(ref arr, arr.Length + 1);
            arr[^1] = item;
            count++;
        }

        void ICollection<T>.Clear() 
            => arr = new T[default];

        bool ICollection<T>.Contains(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (item.Equals(arr[i]))
                {
                    return true;
                }
            }
            return false;
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex) 
            => throw new NotImplementedException();        

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() 
            => throw new NotImplementedException();        

        bool ICollection<T>.Remove(T item)
        {
            int targetElement = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (item.Equals(arr[i]))
                {
                    targetElement = i;
                    break;
                }
            }

            if (targetElement != -1)
            {
                for (int i = targetElement; i < count - 1; i++)
                {
                    arr[targetElement] = arr[targetElement + 1];
                }
                count--;
                return true;
            }
            else return false;
        }

        public IEnumerable<FamilyMember> HeritanceSearch(FamilyMember myFamilyMember, 
            ICollection<FamilyMember> myFamilyTree)
        {
            int[] arr = new int[default];

            if (myFamilyMember.GetID != 0
                && myFamilyMember.GetID != 1
                && myFamilyMember.GetID != 2)
            {
                var firstHer = (myFamilyMember.GetID - 2) / 2;
                Array.Resize(ref arr, arr.Length + 1);
                arr[^1] = firstHer;

                for (int i = 0; i < myFamilyMember.GetLevel - 2; i++)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[^1] = (arr[i] - 1) / 2;
                }
            }
            else if (myFamilyMember.GetID == 1
                || myFamilyMember.GetID == 2)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[^1] = default;
            }
            else throw new Exception("No heritances!");

            foreach (var item in myFamilyTree)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (item.GetID == arr[i])
                    {
                        yield return item;
                    }
                }
            }
        }
    }
}
