namespace Task_003
{
    internal class FamilyMember
    { 
        public string _name; 
        public int _year, _id, _level;

        public string GetName { get => _name; }
        public int GetYear { get => _year; }
        public int GetID { get => _id; }
        public int GetLevel { get => _level; }

        public FamilyMember(string name, int year, int id, int level)
        {
            _name = name;
            _year = year;
            _id = id;
            _level = level;
        }

        public void Show()
            => Console.WriteLine($"{GetName}, {GetYear}, ID: {GetID}, Lvl: {GetLevel}");

        public override int GetHashCode()
        {
            return HashCode.Combine(_name, _year, _id, _level);
        }

        public override bool Equals(Object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            else
            {
                FamilyMember b = (FamilyMember)obj;
                return (_year == b._year) 
                    && (_name == b._name)
                    && (_id == b._id) 
                    && (_level == b._level);
            }
        }
    }
}
