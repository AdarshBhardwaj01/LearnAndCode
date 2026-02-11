public class Customer {
    private String firstName;
    private String lastName;
    private Wallet myWallet;

    public String getFirstName(){ return firstName; }
    public String getLastName(){ return lastName; }

    public boolean pay(double amount) {
        return myWallet.withdraw(amount);
    }
}
