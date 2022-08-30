public class SavingsAccount : BankAccount {
    public SavingsAccount() : base() 
    {
        Balance = 200;
    }

    public SavingsAccount(decimal amount) : base(amount) {

    }

}