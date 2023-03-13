namespace Midterm2{
    class Midterm2{

        static void Main (string[]args) {

                Console.WriteLine("Please input day of week:");
                int day =int.Parse(Console.ReadLine());
                Console.WriteLine("Please input time of day:");
                int time =int.Parse(Console.ReadLine());
                int i=1;
                int i2=1;
                int i3=1;
                int i4=1;
                
               
                
                while(i>0) {
                    Console.WriteLine("Please input menu:");
                     string menu =Console.ReadLine();
                     
                     if (menu == "Breakfast Set"){
                        if(time > 11){
                            Console.WriteLine("Sorry your order is not available");
                        }else{if(i2 >5){
                            Console.WriteLine("Sorry your order is out of stock");
                        }else{
                            i2=i2+1;
                        }


                        }
                     
                     }else{
                        if(menu == "Weekend Set"){

                         if(day != 6 && day != 7){                               
                            Console.WriteLine("Sorry your order is not available");                                                   
                            }else{
                             if(i3>2){
                                Console.WriteLine("Sorry your order is out of stock");
                                }else{
                                    i3=i3+1;
                                }
                             
                             }  

                        } else{
                            if(menu == "Coffee"){
                               
                        if (i4>3){
                            Console.WriteLine("Sorry your order is out of stock");
                            
                        
                     } else{
                        i4=i4+1;
                     }
                           
                            
                        }else{

                            if(menu == "End"){
                            i=0;
                            
                        }else{
                                Console.WriteLine("Please enter a valid menu");
                            
                        }


                    
                       
                        }

                     }
                
                     

                       
                     
                    
                     
                     
                     
                     
                    }
                        

                




                }

                }
                


            





        }
         }
    
  