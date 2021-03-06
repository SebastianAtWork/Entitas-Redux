//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public FlagEntityEventListenerComponent FlagEntityEventListener { get { return (FlagEntityEventListenerComponent)GetComponent(TestComponentsLookup.FlagEntityEventListener); } }
    public bool hasFlagEntityEventListener { get { return HasComponent(TestComponentsLookup.FlagEntityEventListener); } }

    public void AddFlagEntityEventListener(System.Collections.Generic.List<IFlagEntityEventListener> newValue) {
        var index = TestComponentsLookup.FlagEntityEventListener;
        var component = (FlagEntityEventListenerComponent)CreateComponent(index, typeof(FlagEntityEventListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceFlagEntityEventListener(System.Collections.Generic.List<IFlagEntityEventListener> newValue) {
        var index = TestComponentsLookup.FlagEntityEventListener;
        var component = (FlagEntityEventListenerComponent)CreateComponent(index, typeof(FlagEntityEventListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveFlagEntityEventListener() {
        RemoveComponent(TestComponentsLookup.FlagEntityEventListener);
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
public sealed partial class TestMatcher {

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherFlagEntityEventListener;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> FlagEntityEventListener {
        get {
            if (_matcherFlagEntityEventListener == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.FlagEntityEventListener);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherFlagEntityEventListener = matcher;
            }

            return _matcherFlagEntityEventListener;
        }
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
public partial class TestEntity {

    public void AddFlagEntityEventListener(IFlagEntityEventListener value) {
        var listeners = hasFlagEntityEventListener
            ? FlagEntityEventListener.value
            : new System.Collections.Generic.List<IFlagEntityEventListener>();
        listeners.Add(value);
        ReplaceFlagEntityEventListener(listeners);
    }

    public void RemoveFlagEntityEventListener(IFlagEntityEventListener value, bool removeComponentWhenEmpty = true) {
        var listeners = FlagEntityEventListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveFlagEntityEventListener();
        } else {
            ReplaceFlagEntityEventListener(listeners);
        }
    }
}
