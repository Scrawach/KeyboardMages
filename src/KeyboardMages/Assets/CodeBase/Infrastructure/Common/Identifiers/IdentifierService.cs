namespace CodeBase.Infrastructure.Common.Identifiers
{
    public class IdentifierService : IIdentifierService
    {
        private int _previousId = 1;
        
        public int Next() => 
            ++_previousId;
    }
}