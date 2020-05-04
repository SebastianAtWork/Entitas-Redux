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

    public AnyStandardEventListenerComponent AnyStandardEventListener { get { return (AnyStandardEventListenerComponent)GetComponent(TestComponentsLookup.AnyStandardEventListener); } }
    public bool hasAnyStandardEventListener { get { return HasComponent(TestComponentsLookup.AnyStandardEventListener); } }

    public void AddAnyStandardEventListener(System.Collections.Generic.List<IAnyStandardEventListener> newValue) {
        var index = TestComponentsLookup.AnyStandardEventListener;
        var component = (AnyStandardEventListenerComponent)CreateComponent(index, typeof(AnyStandardEventListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyStandardEventListener(System.Collections.Generic.List<IAnyStandardEventListener> newValue) {
        var index = TestComponentsLookup.AnyStandardEventListener;
        var component = (AnyStandardEventListenerComponent)CreateComponent(index, typeof(AnyStandardEventListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyStandardEventListener() {
        RemoveComponent(TestComponentsLookup.AnyStandardEventListener);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherAnyStandardEventListener;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> AnyStandardEventListener {
        get {
            if (_matcherAnyStandardEventListener == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.AnyStandardEventListener);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherAnyStandardEventListener = matcher;
            }

            return _matcherAnyStandardEventListener;
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

    public void AddAnyStandardEventListener(IAnyStandardEventListener value) {
        var listeners = hasAnyStandardEventListener
            ? AnyStandardEventListener.value
            : new System.Collections.Generic.List<IAnyStandardEventListener>();
        listeners.Add(value);
        ReplaceAnyStandardEventListener(listeners);
    }

    public void RemoveAnyStandardEventListener(IAnyStandardEventListener value, bool removeComponentWhenEmpty = true) {
        var listeners = AnyStandardEventListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyStandardEventListener();
        } else {
            ReplaceAnyStandardEventListener(listeners);
        }
    }
}