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

    public TestMultipleEventsStandardEventRemovedListenerComponent TestMultipleEventsStandardEventRemovedListener { get { return (TestMultipleEventsStandardEventRemovedListenerComponent)GetComponent(TestComponentsLookup.TestMultipleEventsStandardEventRemovedListener); } }
    public bool hasTestMultipleEventsStandardEventRemovedListener { get { return HasComponent(TestComponentsLookup.TestMultipleEventsStandardEventRemovedListener); } }

    public void AddTestMultipleEventsStandardEventRemovedListener(System.Collections.Generic.List<ITestMultipleEventsStandardEventRemovedListener> newValue) {
        var index = TestComponentsLookup.TestMultipleEventsStandardEventRemovedListener;
        var component = (TestMultipleEventsStandardEventRemovedListenerComponent)CreateComponent(index, typeof(TestMultipleEventsStandardEventRemovedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTestMultipleEventsStandardEventRemovedListener(System.Collections.Generic.List<ITestMultipleEventsStandardEventRemovedListener> newValue) {
        var index = TestComponentsLookup.TestMultipleEventsStandardEventRemovedListener;
        var component = (TestMultipleEventsStandardEventRemovedListenerComponent)CreateComponent(index, typeof(TestMultipleEventsStandardEventRemovedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTestMultipleEventsStandardEventRemovedListener() {
        RemoveComponent(TestComponentsLookup.TestMultipleEventsStandardEventRemovedListener);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherTestMultipleEventsStandardEventRemovedListener;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> TestMultipleEventsStandardEventRemovedListener {
        get {
            if (_matcherTestMultipleEventsStandardEventRemovedListener == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.TestMultipleEventsStandardEventRemovedListener);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherTestMultipleEventsStandardEventRemovedListener = matcher;
            }

            return _matcherTestMultipleEventsStandardEventRemovedListener;
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

    public void AddTestMultipleEventsStandardEventRemovedListener(ITestMultipleEventsStandardEventRemovedListener value) {
        var listeners = hasTestMultipleEventsStandardEventRemovedListener
            ? TestMultipleEventsStandardEventRemovedListener.value
            : new System.Collections.Generic.List<ITestMultipleEventsStandardEventRemovedListener>();
        listeners.Add(value);
        ReplaceTestMultipleEventsStandardEventRemovedListener(listeners);
    }

    public void RemoveTestMultipleEventsStandardEventRemovedListener(ITestMultipleEventsStandardEventRemovedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = TestMultipleEventsStandardEventRemovedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveTestMultipleEventsStandardEventRemovedListener();
        } else {
            ReplaceTestMultipleEventsStandardEventRemovedListener(listeners);
        }
    }
}