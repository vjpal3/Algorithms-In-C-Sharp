int FirstDuplicate(int[] a)
        {
            foreach(var val in a)
            {
                if (a[Math.Abs(val) - 1] < 0)
                    return Math.Abs(val);

                a[Math.Abs(val) - 1] = -a[Math.Abs(val) - 1];
            }
            return -1;
        }