namespace Facade
{
    public class Mortgage
    {
        Bank _bank = new Bank();
        Credit _credit = new Credit();
        Work _work = new Work();

        public bool IsEligible(User user)
        {
            return _bank.CheckBank(user) &&
                _credit.CheckCredit(user) &&
                _work.CheckWork(user);
        }
    }
}
