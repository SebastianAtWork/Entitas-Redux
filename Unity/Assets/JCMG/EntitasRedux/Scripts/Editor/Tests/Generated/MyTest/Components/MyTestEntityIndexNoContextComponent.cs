//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MyTestEntity {

    public EntitasRedux.Tests.EntityIndexNoContextComponent EntityIndexNoContext { get { return (EntitasRedux.Tests.EntityIndexNoContextComponent)GetComponent(MyTestComponentsLookup.EntityIndexNoContext); } }
    public bool hasEntityIndexNoContext { get { return HasComponent(MyTestComponentsLookup.EntityIndexNoContext); } }

    public void AddEntityIndexNoContext(string newValue) {
        var index = MyTestComponentsLookup.EntityIndexNoContext;
        var component = (EntitasRedux.Tests.EntityIndexNoContextComponent)CreateComponent(index, typeof(EntitasRedux.Tests.EntityIndexNoContextComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEntityIndexNoContext(string newValue) {
        var index = MyTestComponentsLookup.EntityIndexNoContext;
        var component = (EntitasRedux.Tests.EntityIndexNoContextComponent)CreateComponent(index, typeof(EntitasRedux.Tests.EntityIndexNoContextComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEntityIndexNoContext() {
        RemoveComponent(MyTestComponentsLookup.EntityIndexNoContext);
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
public sealed partial class MyTestMatcher {

    static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherEntityIndexNoContext;

    public static JCMG.EntitasRedux.IMatcher<MyTestEntity> EntityIndexNoContext {
        get {
            if (_matcherEntityIndexNoContext == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.EntityIndexNoContext);
                matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
                _matcherEntityIndexNoContext = matcher;
            }

            return _matcherEntityIndexNoContext;
        }
    }
}
