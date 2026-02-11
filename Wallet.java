public class Wallet {
    private double value;

    public boolean withdraw(double amount) {
        if (value >= amount) {
            value -= amount;
            return true;
        }
        return false;
    }
}
