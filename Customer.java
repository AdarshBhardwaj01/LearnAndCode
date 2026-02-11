public class Customer {
    private String firstName;
    private String lastName;
    private Wallet myWallet;

    public String getFirstName(){ return firstName; }
    public String getLastName(){ return lastName; }
    public Wallet getWallet(){ return myWallet; }

    public boolean pay(double amount) {
        if (myWallet.getTotalMoney() >= amount) {
            myWallet.subtractMoney(amount);
            return true;
        }
        return false;
    }
}
