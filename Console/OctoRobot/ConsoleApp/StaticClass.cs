namespace Octo.Robot
{
    //we cannot create the object of static class, this is self single object by itself
    public static class StaticClass
    {
        //each and every members should be static
        static StaticClass()
        {
        }

        private static int I = 10;
        public static int J { get; set; }

        public static void FunctionOne()
        {
            I = 20;
            J = 30;
        }
    }

    public class NonStaticClass
    {
        //may or maynot have static members
        public int i = 20;

        public static int istatic = 20;
        public int j { get; set; }
        public static int jstatic { get; set; }

        public void FunctionOne()
        {
            //nonstatic members have access to both static and non static members
            //can be accessed only by creating objects
            i++;
            istatic++;
            jstatic++;
            j++;
        }

        public static void StaticFunctionOne()
        {
            //static members have access to only static members
            //can be accessed without creating objects
            //i++;
            //j++;
            istatic++;
            jstatic++;
        }
    }
}