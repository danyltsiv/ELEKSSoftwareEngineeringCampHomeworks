package prac1PhoneDirectory;

import java.util.ArrayList;
import java.util.List;

public class Main {

	public static void main(String[] args) {
		
		Dictionary myTelDic = new Dictionary();
		Record rec = new Record("Vasyl","Ivankiv","0555333444","Belvederska street");
		
		try {
			myTelDic.add(rec);
		}
		catch(Throwable ex){
			System.out.println(ex.getMessage());
		}
		
		List<Record> records = myTelDic.getAllRecords();
		for (int i = 0; i < records.size(); i++){
			System.out.println(records.get(i).ToString());
		}
		
	}

}
