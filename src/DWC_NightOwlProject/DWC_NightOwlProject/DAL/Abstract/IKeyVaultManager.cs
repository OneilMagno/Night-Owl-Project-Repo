namespace DWC_NightOwlProject.DAL.Abstract
{
    public interface IKeyVaultManager
    {
        public Task<string> GetSecret(string secretKey);
    }
}
