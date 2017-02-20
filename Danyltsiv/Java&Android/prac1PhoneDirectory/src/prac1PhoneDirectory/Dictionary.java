package prac1PhoneDirectory;

import java.util.ArrayList;
import java.util.List;

public class Dictionary {

	public List<Record> _records;
	
	public Dictionary(){
		this._records = new ArrayList<Record>();
		
		this._records.add(new Record("Andriy","Petrenko","098987654","Vovchynetska street"));
		this._records.add(new Record("Petro","Ivankiv","005555555","Ivasyuka street"));
		this._records.add(new Record("Ruslan","Koniv","023422222","Belvederska street"));
	}
	
	public void add(Record record)throws Throwable{
		for (int i = 0; i < this._records.size(); i++){
			if (this._records.get(i)._Number == record._Number)	
				throw new Exception("Record is already exist!");
		}
			
		this._records.add(record); 
	}
	
	public List<Record> getAllRecords(){
		return this._records;
	}
	
	public List<Record> getByName(String name){
		List<Record> records = new ArrayList<Record>();
		for(int i = 0; i< this._records.size(); i++){
			if (this._records.get(i)._Surname == name)
				records.add(this._records.get(i));
		}
		return records;
	}
	
	public Record getByNumber(String number){
		Record record = null;
		for(int i = 0; i< this._records.size(); i++){
			if (this._records.get(i)._Number == number)
				record = this._records.get(i);
				break;
		}
		return record;
		
	}
	
}
