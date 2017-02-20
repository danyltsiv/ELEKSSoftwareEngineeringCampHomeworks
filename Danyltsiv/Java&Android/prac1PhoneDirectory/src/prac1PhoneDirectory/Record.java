package prac1PhoneDirectory;

public class Record {

	public String _Surname;
	public String _Forename;
    public String _Number;
    public String _Address;

    public Record(String Forename, String Surname,String Number, String Address)
    {
        this._Forename = Forename;
        this._Surname = Surname;
        this._Number = Number;
        this._Address = Address;
    }

    public String ToString(){

        return String.format("%s %s %s %s",this._Forename,this._Surname, this._Number, this._Address);
    }
    
}
