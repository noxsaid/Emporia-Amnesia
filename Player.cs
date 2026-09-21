class Player
{

    public int Row {get; set;}
    public int Col {get; set;}

public BackPack backPack {get;} = new();

    public Player(int startRow, int startCol)
    {
        int Row = startRow;
        int Col = startCol;
    }

}