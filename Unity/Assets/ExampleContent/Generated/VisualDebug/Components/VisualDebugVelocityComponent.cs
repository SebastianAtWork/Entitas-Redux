//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public VelocityComponent Velocity { get { return (VelocityComponent)GetComponent(VisualDebugComponentsLookup.Velocity); } }
    public bool hasVelocity { get { return HasComponent(VisualDebugComponentsLookup.Velocity); } }

    public void AddVelocity(ExampleContent.VisualDebugging.IntVector2 newValue) {
        var index = VisualDebugComponentsLookup.Velocity;
        var component = (VelocityComponent)CreateComponent(index, typeof(VelocityComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceVelocity(ExampleContent.VisualDebugging.IntVector2 newValue) {
        var index = VisualDebugComponentsLookup.Velocity;
        var component = (VelocityComponent)CreateComponent(index, typeof(VelocityComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVelocity() {
        RemoveComponent(VisualDebugComponentsLookup.Velocity);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherVelocity;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Velocity {
        get {
            if (_matcherVelocity == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Velocity);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherVelocity = matcher;
            }

            return _matcherVelocity;
        }
    }
}
