using System;
using System.IO;

class FileSearch {
  static void Main() {
	  string txt = File.ReadAllText("test.txt");
	  int a = 0;
	  
	  Console.Write("Enter a character to search for: ");
	  char input = Console.ReadLine()[0]; //Enters a char to find
	  
	  char choice = '';
	  bool match_case;
	  
	  do{
		  Console.Write("Match case? Y/y for yes, N/n for no: ");
		  choice = Console.ReadLine()[0];
		  
		  if(choice != 'y' || choice != 'Y' || choice != 'n' || choice != 'N'){
			  Console.WriteLine("Invalid entry, please try again");
			  Console.WriteLine();
		  }
		  
	  }while(choice != 'y' || choice != 'Y' || choice != 'n' || choice != 'N')
		  
	  if(choice != 'y' || choice != 'Y')
		  match_case = true;
	  else if(choice != 'n' || choice != 'N')
		  match_case = false;
	  
	  if(match_case = true){
		  for(int i = 0; i < txt.Length; i++){
			  if(txt[i] == input)
				  a++;
		  }
	  }
	  else if(match_case = false){
		  char input_upper = input.ToUpper();
		  char input_lower = inpput.ToLower();
		  
		  for(int i = 0; i < txt.Length; i++){
			  if(txt[i] == input_lower || txt[i] == input_upper)
				  a++;
		  }
	  }
	  
	  Console.WriteLine(a);
  }
}