class Map
{
    private Location?[][] locaitons =
    {
        new Location?[5] {null,              null,              new Escallator1(),       new Roof(),           null},
        new Location?[5] {new Foyer(),       new Escallator2(), new CorridorA(),         null,                 null},
        new Location?[5] {new TolietStall(), null,              new OutSideDryCleaner(), new CorridorB(),      null},
        new Location?[5] {null,              null,              new Drycleaner(),        new Securityoffice(), new TaxtSation()}
    };



    public Location GetLocation(int row, int col)
    {
        return locaitons[row][col]!; // assertion, we promis this will exist
    }



    public bool PositionExsists(int row, int col)
    {
        if(row < 0 || row >= locaitons.Length) // is row out of bounds?
        {
            return false;
        }

        if (col < 0 || col >= locaitons[row].Length) // is row out of bounds?
        {
            return false;
        }

        if (locaitons[row][col] == null) // is postion on a null"Cell"?
        {
            return false;
        }

        return true;

    }



}