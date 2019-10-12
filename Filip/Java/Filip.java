package Filip.Java;

import java.util.Scanner;

/**
 * Filip
 */
public class Filip {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        while (sc.hasNext()) {
            String[] numbers = sc.nextLine().split(" ");
            String[] first = numbers[0].split("");
            String[] second = numbers[1].split("(?!^)");

            for (int i = 2 ; i >= 0 ; i--) {
                if (Integer.parseInt(first[i]) > Integer.parseInt(second[i])) {
                    System.out.println(first[2] + first[1] + first[0]);
                    break;
                }
                else if (Integer.parseInt(first[i]) < Integer.parseInt(second[i])) {
                    System.out.println(second[2] + second[1] + second[0]);
                    break;
                }
            }
        }
        sc.close();
    }
}