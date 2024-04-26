// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentBoxGachaManageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentBoxGachaManageExcel GetRootAsEventContentBoxGachaManageExcel(ByteBuffer _bb) { return GetRootAsEventContentBoxGachaManageExcel(_bb, new EventContentBoxGachaManageExcel()); }
  public static EventContentBoxGachaManageExcel GetRootAsEventContentBoxGachaManageExcel(ByteBuffer _bb, EventContentBoxGachaManageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentBoxGachaManageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Round { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GoodsId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsLoop { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<SCHALE.Common.FlatData.EventContentBoxGachaManageExcel> CreateEventContentBoxGachaManageExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long Round = 0,
      long GoodsId = 0,
      bool IsLoop = false) {
    builder.StartTable(4);
    EventContentBoxGachaManageExcel.AddGoodsId(builder, GoodsId);
    EventContentBoxGachaManageExcel.AddRound(builder, Round);
    EventContentBoxGachaManageExcel.AddEventContentId(builder, EventContentId);
    EventContentBoxGachaManageExcel.AddIsLoop(builder, IsLoop);
    return EventContentBoxGachaManageExcel.EndEventContentBoxGachaManageExcel(builder);
  }

  public static void StartEventContentBoxGachaManageExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddRound(FlatBufferBuilder builder, long round) { builder.AddLong(1, round, 0); }
  public static void AddGoodsId(FlatBufferBuilder builder, long goodsId) { builder.AddLong(2, goodsId, 0); }
  public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop) { builder.AddBool(3, isLoop, false); }
  public static Offset<SCHALE.Common.FlatData.EventContentBoxGachaManageExcel> EndEventContentBoxGachaManageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EventContentBoxGachaManageExcel>(o);
  }
}


static public class EventContentBoxGachaManageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Round*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*GoodsId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*IsLoop*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}