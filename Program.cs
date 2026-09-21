Map map = new Map();

if(map.PositionExsists(1, 0))
{
    Location loc = map.GetLocation(1,0);
    Console.Write(loc);
}


if(map.PositionExsists(5, 5))
{
    Location loc2 = map.GetLocation(5,5);
    Console.Write(loc2);
}

if(map.PositionExsists(4, 4))
{
    Location loc3 = map.GetLocation(4, 4);
    Console.Write(loc3);
}

if(map.PositionExsists(3, 0))
{
    Location loc4 = map.GetLocation(3, 0);
    Console.Write(loc4);
}