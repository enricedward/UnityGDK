// Generated by SpatialOS codegen. DO NOT EDIT!
// source: improbable.gdk.tests.ExhaustiveSingularData in improbable/gdk/tests/exhaustive_test.schema.

namespace Improbable.Gdk.Tests
{

public partial struct ExhaustiveSingularData : global::System.IEquatable<ExhaustiveSingularData>, global::Improbable.Collections.IDeepCopyable<ExhaustiveSingularData>
{
  /// <summary>
  /// Field field1 = 1.
  /// </summary>
  public bool field1;
  /// <summary>
  /// Field field2 = 2.
  /// </summary>
  public float field2;
  /// <summary>
  /// Field field4 = 4.
  /// </summary>
  public int field4;
  /// <summary>
  /// Field field5 = 5.
  /// </summary>
  public long field5;
  /// <summary>
  /// Field field6 = 6.
  /// </summary>
  public double field6;
  /// <summary>
  /// Field field7 = 7.
  /// </summary>
  public string field7;
  /// <summary>
  /// Field field8 = 8.
  /// </summary>
  public uint field8;
  /// <summary>
  /// Field field9 = 9.
  /// </summary>
  public ulong field9;
  /// <summary>
  /// Field field10 = 10.
  /// </summary>
  public int field10;
  /// <summary>
  /// Field field11 = 11.
  /// </summary>
  public long field11;
  /// <summary>
  /// Field field12 = 12.
  /// </summary>
  public uint field12;
  /// <summary>
  /// Field field13 = 13.
  /// </summary>
  public ulong field13;
  /// <summary>
  /// Field field14 = 14.
  /// </summary>
  public int field14;
  /// <summary>
  /// Field field15 = 15.
  /// </summary>
  public long field15;
  /// <summary>
  /// Field field16 = 16.
  /// </summary>
  public global::Improbable.EntityId field16;
  /// <summary>
  /// Field field17 = 17.
  /// </summary>
  public global::Improbable.Gdk.Tests.SomeType field17;

  public ExhaustiveSingularData(
      bool field1,
      float field2,
      int field4,
      long field5,
      double field6,
      string field7,
      uint field8,
      ulong field9,
      int field10,
      long field11,
      uint field12,
      ulong field13,
      int field14,
      long field15,
      global::Improbable.EntityId field16,
      global::Improbable.Gdk.Tests.SomeType field17)
  {
    this.field1 = field1;
    this.field2 = field2;
    this.field4 = field4;
    this.field5 = field5;
    this.field6 = field6;
    this.field7 = field7;
    this.field8 = field8;
    this.field9 = field9;
    this.field10 = field10;
    this.field11 = field11;
    this.field12 = field12;
    this.field13 = field13;
    this.field14 = field14;
    this.field15 = field15;
    this.field16 = field16;
    this.field17 = field17;
  }

  public static ExhaustiveSingularData Create()
  {
    var _result = new ExhaustiveSingularData();
    _result.field7 = "";
    _result.field17 = global::Improbable.Gdk.Tests.SomeType.Create();
    return _result;
  }

  public ExhaustiveSingularData DeepCopy()
  {
    var _result = new ExhaustiveSingularData();
    _result.field1 = field1;
    _result.field2 = field2;
    _result.field4 = field4;
    _result.field5 = field5;
    _result.field6 = field6;
    _result.field7 = field7;
    _result.field8 = field8;
    _result.field9 = field9;
    _result.field10 = field10;
    _result.field11 = field11;
    _result.field12 = field12;
    _result.field13 = field13;
    _result.field14 = field14;
    _result.field15 = field15;
    _result.field16 = field16;
    _result.field17 = field17.DeepCopy();
    return _result;

  }

  public override bool Equals(object _obj)
  {
    return _obj is ExhaustiveSingularData && Equals((ExhaustiveSingularData) _obj);
  }

  public static bool operator==(ExhaustiveSingularData a, ExhaustiveSingularData b)
  {
    return a.Equals(b);
  }

  public static bool operator!=(ExhaustiveSingularData a, ExhaustiveSingularData b)
  {
    return !a.Equals(b);
  }

  public bool Equals(ExhaustiveSingularData _obj)
  {
    return
        field1 == _obj.field1 &&
        field2 == _obj.field2 &&
        field4 == _obj.field4 &&
        field5 == _obj.field5 &&
        field6 == _obj.field6 &&
        field7 == _obj.field7 &&
        field8 == _obj.field8 &&
        field9 == _obj.field9 &&
        field10 == _obj.field10 &&
        field11 == _obj.field11 &&
        field12 == _obj.field12 &&
        field13 == _obj.field13 &&
        field14 == _obj.field14 &&
        field15 == _obj.field15 &&
        field16 == _obj.field16 &&
        field17 == _obj.field17;
  }

  public override int GetHashCode()
  {
    int _result = 1327;
    _result = (_result * 977) + field1.GetHashCode();
    _result = (_result * 977) + field2.GetHashCode();
    _result = (_result * 977) + field4.GetHashCode();
    _result = (_result * 977) + field5.GetHashCode();
    _result = (_result * 977) + field6.GetHashCode();
    _result = (_result * 977) + (field7 == null ? 0 : field7.GetHashCode());
    _result = (_result * 977) + field8.GetHashCode();
    _result = (_result * 977) + field9.GetHashCode();
    _result = (_result * 977) + field10.GetHashCode();
    _result = (_result * 977) + field11.GetHashCode();
    _result = (_result * 977) + field12.GetHashCode();
    _result = (_result * 977) + field13.GetHashCode();
    _result = (_result * 977) + field14.GetHashCode();
    _result = (_result * 977) + field15.GetHashCode();
    _result = (_result * 977) + field16.GetHashCode();
    _result = (_result * 977) + field17.GetHashCode();
    return _result;
  }
}

public static class ExhaustiveSingularData_Internal
{
  public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                  ExhaustiveSingularData _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
  {
    {
      global::Improbable.Worker.Internal.Pbio.AddBool(_obj, 1, (byte) (_data.field1 ? 1 : 0));
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddFloat(_obj, 2, _data.field2);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddInt32(_obj, 4, _data.field4);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddInt64(_obj, 5, _data.field5);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddDouble(_obj, 6, _data.field6);
    }
    {
      if (_data.field7 != null)
      {
        var _buffer = global::System.Text.Encoding.UTF8.GetBytes(_data.field7);
        global::Improbable.Worker.Internal.Pbio.AddBytes(_obj, 7, (byte*) _pool.Pin(_buffer), (uint) _buffer.Length);
      }
      else{
        global::Improbable.Worker.Internal.Pbio.AddBytes(_obj, 7, null, 0);
      }
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddUint32(_obj, 8, _data.field8);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddUint64(_obj, 9, _data.field9);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddSint32(_obj, 10, _data.field10);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddSint64(_obj, 11, _data.field11);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddFixed32(_obj, 12, _data.field12);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddFixed64(_obj, 13, _data.field13);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddSfixed32(_obj, 14, _data.field14);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddSfixed64(_obj, 15, _data.field15);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddInt64(_obj, 16, _data.field16.Id);
    }
    {
      global::Improbable.Gdk.Tests.SomeType_Internal.Write(_pool, _data.field17, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 17));
    }
  }

  public static unsafe ExhaustiveSingularData Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
  {
    ExhaustiveSingularData _data;
    {
      _data.field1 = global::Improbable.Worker.Internal.Pbio.GetBool(_obj, 1) != 0;
    }
    {
      _data.field2 = global::Improbable.Worker.Internal.Pbio.GetFloat(_obj, 2);
    }
    {
      _data.field4 = global::Improbable.Worker.Internal.Pbio.GetInt32(_obj, 4);
    }
    {
      _data.field5 = global::Improbable.Worker.Internal.Pbio.GetInt64(_obj, 5);
    }
    {
      _data.field6 = global::Improbable.Worker.Internal.Pbio.GetDouble(_obj, 6);
    }
    {
      _data.field7 = global::System.Text.Encoding.UTF8.GetString(global::Improbable.Worker.Bytes.CopyOf(global::Improbable.Worker.Internal.Pbio.GetBytes(_obj, 7), global::Improbable.Worker.Internal.Pbio.GetBytesLength(_obj, 7)).BackingArray);
    }
    {
      _data.field8 = global::Improbable.Worker.Internal.Pbio.GetUint32(_obj, 8);
    }
    {
      _data.field9 = global::Improbable.Worker.Internal.Pbio.GetUint64(_obj, 9);
    }
    {
      _data.field10 = global::Improbable.Worker.Internal.Pbio.GetSint32(_obj, 10);
    }
    {
      _data.field11 = global::Improbable.Worker.Internal.Pbio.GetSint64(_obj, 11);
    }
    {
      _data.field12 = global::Improbable.Worker.Internal.Pbio.GetFixed32(_obj, 12);
    }
    {
      _data.field13 = global::Improbable.Worker.Internal.Pbio.GetFixed64(_obj, 13);
    }
    {
      _data.field14 = global::Improbable.Worker.Internal.Pbio.GetSfixed32(_obj, 14);
    }
    {
      _data.field15 = global::Improbable.Worker.Internal.Pbio.GetSfixed64(_obj, 15);
    }
    {
      _data.field16 = new global::Improbable.EntityId(global::Improbable.Worker.Internal.Pbio.GetInt64(_obj, 16));
    }
    {
      _data.field17 = global::Improbable.Gdk.Tests.SomeType_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 17));
    }
    return _data;
  }
}

}
