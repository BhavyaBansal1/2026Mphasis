namespace day2.designpattern;
class Logger{
    private static Logger instance;
    private Logger(){

    }
    public static Logger GetInstance(){
        if(instance==null)
        instance=new Logger();
        return instance;
    }
    public void log(string message){
        Console.WriteLine("log"+message);
    }
}

class sigleton{
    public static void Main(){
        Logger log1=Logger.GetInstance();
        Logger log2=Logger.GetInstance();
        log1.log("this is singleton example");
        Console.WriteLine(object.ReferenceEquals(log1,log2));
    }
}