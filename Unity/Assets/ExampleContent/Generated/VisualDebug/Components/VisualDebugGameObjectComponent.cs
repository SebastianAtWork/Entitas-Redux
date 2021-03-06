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

    public ExampleContent.VisualDebugging.GameObjectComponent GameObject { get { return (ExampleContent.VisualDebugging.GameObjectComponent)GetComponent(VisualDebugComponentsLookup.GameObject); } }
    public bool hasGameObject { get { return HasComponent(VisualDebugComponentsLookup.GameObject); } }

    public void AddGameObject(UnityEngine.GameObject newGameObject) {
        var index = VisualDebugComponentsLookup.GameObject;
        var component = (ExampleContent.VisualDebugging.GameObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.GameObjectComponent));
        component.gameObject = newGameObject;
        AddComponent(index, component);
    }

    public void ReplaceGameObject(UnityEngine.GameObject newGameObject) {
        var index = VisualDebugComponentsLookup.GameObject;
        var component = (ExampleContent.VisualDebugging.GameObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.GameObjectComponent));
        component.gameObject = newGameObject;
        ReplaceComponent(index, component);
    }

    public void RemoveGameObject() {
        RemoveComponent(VisualDebugComponentsLookup.GameObject);
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

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherGameObject;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> GameObject {
        get {
            if (_matcherGameObject == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.GameObject);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherGameObject = matcher;
            }

            return _matcherGameObject;
        }
    }
}
