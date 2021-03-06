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

    public EntitasRedux.Tests.StandardEntityEventComponent StandardEntityEvent { get { return (EntitasRedux.Tests.StandardEntityEventComponent)GetComponent(TestComponentsLookup.StandardEntityEvent); } }
    public bool hasStandardEntityEvent { get { return HasComponent(TestComponentsLookup.StandardEntityEvent); } }

    public void AddStandardEntityEvent(string newValue) {
        var index = TestComponentsLookup.StandardEntityEvent;
        var component = (EntitasRedux.Tests.StandardEntityEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.StandardEntityEventComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStandardEntityEvent(string newValue) {
        var index = TestComponentsLookup.StandardEntityEvent;
        var component = (EntitasRedux.Tests.StandardEntityEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.StandardEntityEventComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStandardEntityEvent() {
        RemoveComponent(TestComponentsLookup.StandardEntityEvent);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherStandardEntityEvent;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> StandardEntityEvent {
        get {
            if (_matcherStandardEntityEvent == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.StandardEntityEvent);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherStandardEntityEvent = matcher;
            }

            return _matcherStandardEntityEvent;
        }
    }
}
