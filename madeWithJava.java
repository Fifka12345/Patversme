import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        //Data
        String shelterName;
        int dogs;
        int cats;
        int animals;
        float dogPercent;
        float catPercent;
        
        boolean TryAgain = true;
        while(TryAgain){
            try{
                System.out.println("Please, write shelter name: ");
                shelterName = input.nextLine();
                
                System.out.println("Please, enter amount of dogs: ");
                dogs = input.nextInt();
        
                System.out.println("Please, enter amount of cats: ");
                cats = input.nextInt();
                
               
                animals = (dogs + cats);
                dogPercent = (float) ((dogs*100) / animals);
                catPercent = (float) ((cats*100) / animals);
        
                System.out.println("Shelter: " + shelterName + " holds " + animals + " animals in total. Dogs make " + dogPercent + "% of animals in the shelter, but cats make " + catPercent + "% of animals in the shelter.");
                TryAgain = false;
            }
            catch (Exception e){
                System.out.println("An error occurred!");
                input.nextLine();
            }
        }
    }
}
