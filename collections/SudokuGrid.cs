// Check if given suduko 9 × 9 grid is valid  
// if each column, each row, and each 3 × 3 subgrid can only contain the numbers 1 through 9 one time.

bool sudokuGrid(char[][] grid) {
    for (var i = 0; i < 9; i++) {
        var charSet = new HashSet<string>();
        
        for(var j = 0; j < 9; j++) {
                                               
            if (grid[i][j] != '.' && !charSet.Add(grid[i][j] + "r"))
                return false;
            if (grid[j][i] != '.' && !charSet.Add(grid[j][i] + "c"))
                return false;
            if (grid[i/3*3+j/3][i%3*3+j%3] != '.' && !charSet.Add(grid[i/3*3+j/3][i%3*3+j%3] + "s"))
                return false;
        }
    }
    return true;
}
