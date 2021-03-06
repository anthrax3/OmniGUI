﻿namespace OmniGui.Xaml
{
    using OmniXaml;

    public class TemplateBind : IMarkupExtension
    {
        public TemplateBind(string targetProperty)
        {
            TargetProperty = targetProperty;
        }

        public object GetValue(ExtensionValueContext context)
        {
            return new BindDefinition(context.Assignment.Target.Instance, context.Assignment.Member, TargetProperty, LinkMode)
            {
                Source = BindingSource.TemplatedParent
            };
        }

        public string TargetProperty { get; }
        public LinkMode LinkMode { get; set; }
    }
}