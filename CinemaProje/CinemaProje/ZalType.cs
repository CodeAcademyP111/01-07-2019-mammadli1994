namespace CinemaProje
{
    public class ZalType
    {
        private static int ID;
        private int uniqueId;
        public string TypeName { get; set; }


        public ZalType(string type)
        {
            ID++;
            uniqueId = ID;
            TypeName = type;
        }
        public int GetId()
        {
            return uniqueId;
        }
    }
}