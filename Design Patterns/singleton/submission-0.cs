public class Singleton {

    private string singletonValue;
    private static Singleton singletonObject;

    private Singleton() {
      
    }

    public static Singleton getInstance() {
        if(singletonObject == null)
        {
           singletonObject = new Singleton();
        }
        return singletonObject;
    }

    public string getValue() {
        return this.singletonValue;
    }

    public void setValue(string value){
        this.singletonValue = value;
    }
}
