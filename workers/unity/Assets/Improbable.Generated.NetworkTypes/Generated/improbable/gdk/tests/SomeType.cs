// Generated by SpatialOS codegen. DO NOT EDIT!
// source: improbable.gdk.tests.SomeType in improbable/gdk/tests/exhaustive_test.schema.

namespace Improbable.Gdk.Tests
{

public partial struct SomeType : global::System.IEquatable<SomeType>, global::Improbable.Collections.IDeepCopyable<SomeType>
{
  public static SomeType Create()
  {
    var _result = new SomeType();
    return _result;
  }

  public SomeType DeepCopy()
  {
    var _result = new SomeType();
    return _result;

  }

  public override bool Equals(object _obj)
  {
    return _obj is SomeType && Equals((SomeType) _obj);
  }

  public static bool operator==(SomeType a, SomeType b)
  {
    return a.Equals(b);
  }

  public static bool operator!=(SomeType a, SomeType b)
  {
    return !a.Equals(b);
  }

  public bool Equals(SomeType _obj)
  {
    return true;
  }

  public override int GetHashCode()
  {
    int _result = 1327;
    return _result;
  }
}

public static class SomeType_Internal
{
  public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                  SomeType _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
  {
  }

  public static unsafe SomeType Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
  {
    SomeType _data;
    return _data;
  }
}

}
