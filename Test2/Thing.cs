namespace Test2
{
    public class Thing
    {
        private string _name;

        public Thing(string name)
        {
            _name = name;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }

    public class Room : Thing
    {
        private int _north, _south, _west, _east;

        public Room(string name, int north, int south, int west, int east)
            : base(name)
        {
            _north = north;
            _south = south;
            _west = west;
            _east = east;
        }
        public int North
        {
            get => _north;
        }

        public int South
        {
            get => _south;
        }

        public int West
        {
            get => _west;
        }

        public int East
        {
            get => _east;
        }
    
    }
}