// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/MLinkRest/BucketRange.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/MLinkRest/BucketRange.proto</summary>
  public static partial class BucketRangeReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/MLinkRest/BucketRange.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BucketRangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQcm90b2J1Zi9NTGlua1Jlc3QvQnVja2V0UmFuZ2UucHJvdG8SE3NwaWRl",
            "cnJvY2sucHJvdG9idWYaF3NwaWRlcnJvY2tfY29tbW9uLnByb3RvIpMBCgtC",
            "dWNrZXRSYW5nZRIzCgVfbWV0YRgBIAEoCzIkLnNwaWRlcnJvY2sucHJvdG9i",
            "dWYuTWVzc2FnZU1ldGFkYXRhEgwKBG5hbWUYZCABKAkSDQoFZl9udW0YZyAB",
            "KA0SCwoDa2V5GGogASgJEgsKA21pbhhtIAEoCRILCgNtYXgYcCABKAkSCwoD",
            "Y250GHMgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.BucketRange), global::Spiderrock.Protobuf.BucketRange.Parser, new[]{ "Meta", "Name", "FNum", "Key", "Min", "Max", "Cnt" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BucketRange : pb::IMessage<BucketRange>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BucketRange> _parser = new pb::MessageParser<BucketRange>(() => new BucketRange());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BucketRange> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.BucketRangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BucketRange() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BucketRange(BucketRange other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      name_ = other.name_;
      fNum_ = other.fNum_;
      key_ = other.key_;
      min_ = other.min_;
      max_ = other.max_;
      cnt_ = other.cnt_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BucketRange Clone() {
      return new BucketRange(this);
    }

    /// <summary>Field number for the "_meta" field.</summary>
    public const int MetaFieldNumber = 1;
    private global::Spiderrock.Protobuf.MessageMetadata Meta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.MessageMetadata Meta {
      get { return Meta_; }
      set {
        Meta_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 100;
    private string name_ = "";
    /// <summary>
    /// field name from the 'group' clause
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "f_num" field.</summary>
    public const int FNumFieldNumber = 103;
    private uint fNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FNum {
      get { return fNum_; }
      set {
        fNum_ = value;
      }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 106;
    private string key_ = "";
    /// <summary>
    /// is one of key1, key2, key3, or key4 from an aggregate composite bucket result
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "min" field.</summary>
    public const int MinFieldNumber = 109;
    private string min_ = "";
    /// <summary>
    /// bucket range is [min, max);  might be an int, double, string, or datetime (all encoded as strings)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Min {
      get { return min_; }
      set {
        min_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "max" field.</summary>
    public const int MaxFieldNumber = 112;
    private string max_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Max {
      get { return max_; }
      set {
        max_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cnt" field.</summary>
    public const int CntFieldNumber = 115;
    private int cnt_;
    /// <summary>
    /// number of items in this bucket
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Cnt {
      get { return cnt_; }
      set {
        cnt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BucketRange);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BucketRange other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (Name != other.Name) return false;
      if (FNum != other.FNum) return false;
      if (Key != other.Key) return false;
      if (Min != other.Min) return false;
      if (Max != other.Max) return false;
      if (Cnt != other.Cnt) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (FNum != 0) hash ^= FNum.GetHashCode();
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (Min.Length != 0) hash ^= Min.GetHashCode();
      if (Max.Length != 0) hash ^= Max.GetHashCode();
      if (Cnt != 0) hash ^= Cnt.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Meta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Meta);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(Name);
      }
      if (FNum != 0) {
        output.WriteRawTag(184, 6);
        output.WriteUInt32(FNum);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(Key);
      }
      if (Min.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(Min);
      }
      if (Max.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(Max);
      }
      if (Cnt != 0) {
        output.WriteRawTag(152, 7);
        output.WriteInt32(Cnt);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Meta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Meta);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(Name);
      }
      if (FNum != 0) {
        output.WriteRawTag(184, 6);
        output.WriteUInt32(FNum);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(Key);
      }
      if (Min.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(Min);
      }
      if (Max.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(Max);
      }
      if (Cnt != 0) {
        output.WriteRawTag(152, 7);
        output.WriteInt32(Cnt);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Meta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Meta);
      }
      if (Name.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (FNum != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(FNum);
      }
      if (Key.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (Min.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Min);
      }
      if (Max.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Max);
      }
      if (Cnt != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Cnt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BucketRange other) {
      if (other == null) {
        return;
      }
      if (other.Meta_ != null) {
        if (Meta_ == null) {
          Meta = new global::Spiderrock.Protobuf.MessageMetadata();
        }
        Meta.MergeFrom(other.Meta);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.FNum != 0) {
        FNum = other.FNum;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.Min.Length != 0) {
        Min = other.Min;
      }
      if (other.Max.Length != 0) {
        Max = other.Max;
      }
      if (other.Cnt != 0) {
        Cnt = other.Cnt;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (Meta_ == null) {
              Meta = new global::Spiderrock.Protobuf.MessageMetadata();
            }
            input.ReadMessage(Meta);
            break;
          }
          case 802: {
            Name = input.ReadString();
            break;
          }
          case 824: {
            FNum = input.ReadUInt32();
            break;
          }
          case 850: {
            Key = input.ReadString();
            break;
          }
          case 874: {
            Min = input.ReadString();
            break;
          }
          case 898: {
            Max = input.ReadString();
            break;
          }
          case 920: {
            Cnt = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (Meta_ == null) {
              Meta = new global::Spiderrock.Protobuf.MessageMetadata();
            }
            input.ReadMessage(Meta);
            break;
          }
          case 802: {
            Name = input.ReadString();
            break;
          }
          case 824: {
            FNum = input.ReadUInt32();
            break;
          }
          case 850: {
            Key = input.ReadString();
            break;
          }
          case 874: {
            Min = input.ReadString();
            break;
          }
          case 898: {
            Max = input.ReadString();
            break;
          }
          case 920: {
            Cnt = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
