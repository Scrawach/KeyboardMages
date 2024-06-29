namespace CodeBase.Common.Entities
{
    public static class CreateInputEntity
    {
        public static InputEntity Empty() =>
            Contexts.sharedInstance.input.CreateEntity();
    }
}