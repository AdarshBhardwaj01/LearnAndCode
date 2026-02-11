public class Paperboy {
    public void collectPayment(Customer customer, double paymentAmount) {
        if (!customer.pay(paymentAmount)) {
            // come back later
        }
    }
}
