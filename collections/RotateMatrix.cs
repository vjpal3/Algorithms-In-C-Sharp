int[][] RotateMatrix (int[][] a) {
    int n = a.Length;
    int [][] result = new int[n][];

    for (var i = 0; i < n; i++) {
      result[i] = new int[n];
    }

    for(int i = 0; i < n; i++ ){
        int m = n-1;
        for(int j = 0; j < n; j++) {
            result[i][j] = a[m][i];
            m--;
        }
    }
    return result;
}
