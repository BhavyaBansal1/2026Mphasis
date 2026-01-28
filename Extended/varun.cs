namespace day4{
// Class must be static when usig extention method
     public static  class varun{
        public static void lunch(this sai s){
            Console.WriteLine("Lunch At 1Pm");
        }
          public static void holiday(this sai s){
            Console.WriteLine("holiday At 85m");
        }
        public static void Main(){
                sai obj=new sai();
                obj.lunch();
                obj.study();
                    obj.holiday();


        }}}