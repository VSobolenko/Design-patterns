namespace Design_patterns.Commands
{
    interface ICommand
    {
        bool CanModify { get; }
        void Execute();
    }
}
