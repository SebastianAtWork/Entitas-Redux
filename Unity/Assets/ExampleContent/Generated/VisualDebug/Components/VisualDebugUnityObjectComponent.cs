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

    public ExampleContent.VisualDebugging.UnityObjectComponent UnityObject { get { return (ExampleContent.VisualDebugging.UnityObjectComponent)GetComponent(VisualDebugComponentsLookup.UnityObject); } }
    public bool hasUnityObject { get { return HasComponent(VisualDebugComponentsLookup.UnityObject); } }

    public void AddUnityObject(UnityEngine.Object newUnityObject) {
        var index = VisualDebugComponentsLookup.UnityObject;
        var component = (ExampleContent.VisualDebugging.UnityObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.UnityObjectComponent));
        component.unityObject = newUnityObject;
        AddComponent(index, component);
    }

    public void ReplaceUnityObject(UnityEngine.Object newUnityObject) {
        var index = VisualDebugComponentsLookup.UnityObject;
        var component = (ExampleContent.VisualDebugging.UnityObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.UnityObjectComponent));
        component.unityObject = newUnityObject;
        ReplaceComponent(index, component);
    }

    public void RemoveUnityObject() {
        RemoveComponent(VisualDebugComponentsLookup.UnityObject);
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

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherUnityObject;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> UnityObject {
        get {
            if (_matcherUnityObject == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.UnityObject);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherUnityObject = matcher;
            }

            return _matcherUnityObject;
        }
    }
}