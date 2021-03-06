namespace OmniGui.VisualStates
{
    using Zafiro.PropertySystem;
    using Zafiro.PropertySystem.Standard;

    public class StateTrigger
    {
        private readonly IPropertyEngine propertyEngine;
        public static ExtendedProperty IsActiveProperty;

        public StateTrigger(IPropertyEngine propertyEngine)
        {
            this.propertyEngine = propertyEngine;
            IsActiveProperty = propertyEngine.RegisterProperty("IsActive", typeof(StateTrigger), typeof(bool),
                new PropertyMetadata());
        }
        public bool IsActive
        {
            get => (bool) propertyEngine.GetValue(IsActiveProperty, this);
            set => propertyEngine.SetValue(IsActiveProperty, this, value);
        }
    }
}