// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: WaiterService.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WaiterServiceProto {

  /// <summary>Holder for reflection information generated from WaiterService.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class WaiterServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for WaiterService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WaiterServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNXYWl0ZXJTZXJ2aWNlLnByb3RvEhJXYWl0ZXJTZXJ2aWNlUHJvdG8iBwoF",
            "RW1wdHkiEwoCSWQSDQoFdmFsdWUYASABKAUiFQoEQm9vbBINCgV2YWx1ZRgB",
            "IAEoCCI4CgdQcm9kdWN0EgoKAmlkGAEgASgFEgwKBG5hbWUYAiABKAkSEwoL",
            "ZGVzY3JpcHRpb24YAyABKAkiVAoFT3JkZXISCgoCaWQYASABKAUSDQoFdGFi",
            "bGUYAiABKAUSMAoIcHJvZHVjdHMYAyABKAsyHi5XYWl0ZXJTZXJ2aWNlUHJv",
            "dG8ucHJvZHVjdEFyciI5Cgpwcm9kdWN0QXJyEisKBnZhbHVlcxgBIAMoCzIb",
            "LldhaXRlclNlcnZpY2VQcm90by5Qcm9kdWN0IjUKCG9yZGVyQXJyEikKBnZh",
            "bHVlcxgBIAMoCzIZLldhaXRlclNlcnZpY2VQcm90by5PcmRlcjLBAwoNV2Fp",
            "dGVyU2VydmljZRJMCg1jaGVja1Byb2R1Y3RzEhkuV2FpdGVyU2VydmljZVBy",
            "b3RvLkVtcHR5Gh4uV2FpdGVyU2VydmljZVByb3RvLnByb2R1Y3RBcnIiABJB",
            "CghhZGRPcmRlchIZLldhaXRlclNlcnZpY2VQcm90by5PcmRlchoYLldhaXRl",
            "clNlcnZpY2VQcm90by5Cb29sIgASQAoKY2xvc2VPcmRlchIWLldhaXRlclNl",
            "cnZpY2VQcm90by5JZBoYLldhaXRlclNlcnZpY2VQcm90by5Cb29sIgASQQoL",
            "Y2FuY2VsT3JkZXISFi5XYWl0ZXJTZXJ2aWNlUHJvdG8uSWQaGC5XYWl0ZXJT",
            "ZXJ2aWNlUHJvdG8uQm9vbCIAEkwKD2dldEFjdGl2ZU9yZGVycxIZLldhaXRl",
            "clNlcnZpY2VQcm90by5FbXB0eRocLldhaXRlclNlcnZpY2VQcm90by5vcmRl",
            "ckFyciIAEkwKD2dldENsb3NlZE9yZGVycxIZLldhaXRlclNlcnZpY2VQcm90",
            "by5FbXB0eRocLldhaXRlclNlcnZpY2VQcm90by5vcmRlckFyciIAQkEKI2lv",
            "LmdycGMuZXhhbXBsZXMuV2FpdGVyU2VydmljZVByb3RvQhJXYWl0ZXJTZXJ2",
            "aWNlUHJvdG9QAaICA0hMV2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::WaiterServiceProto.Empty), global::WaiterServiceProto.Empty.Parser, null, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::WaiterServiceProto.Id), global::WaiterServiceProto.Id.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::WaiterServiceProto.Bool), global::WaiterServiceProto.Bool.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::WaiterServiceProto.Product), global::WaiterServiceProto.Product.Parser, new[]{ "Id", "Name", "Description" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::WaiterServiceProto.Order), global::WaiterServiceProto.Order.Parser, new[]{ "Id", "Table", "Products" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::WaiterServiceProto.productArr), global::WaiterServiceProto.productArr.Parser, new[]{ "Values" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::WaiterServiceProto.orderArr), global::WaiterServiceProto.orderArr.Parser, new[]{ "Values" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Empty : pb::IMessage<Empty> {
    private static readonly pb::MessageParser<Empty> _parser = new pb::MessageParser<Empty>(() => new Empty());
    public static pb::MessageParser<Empty> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::WaiterServiceProto.WaiterServiceReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Empty() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Empty(Empty other) : this() {
    }

    public Empty Clone() {
      return new Empty(this);
    }

    public override bool Equals(object other) {
      return Equals(other as Empty);
    }

    public bool Equals(Empty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(Empty other) {
      if (other == null) {
        return;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Id : pb::IMessage<Id> {
    private static readonly pb::MessageParser<Id> _parser = new pb::MessageParser<Id>(() => new Id());
    public static pb::MessageParser<Id> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::WaiterServiceProto.WaiterServiceReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Id() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Id(Id other) : this() {
      value_ = other.value_;
    }

    public Id Clone() {
      return new Id(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private int value_;
    public int Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Id);
    }

    public bool Equals(Id other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Value);
      }
      return size;
    }

    public void MergeFrom(Id other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Value = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Bool : pb::IMessage<Bool> {
    private static readonly pb::MessageParser<Bool> _parser = new pb::MessageParser<Bool>(() => new Bool());
    public static pb::MessageParser<Bool> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::WaiterServiceProto.WaiterServiceReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Bool() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Bool(Bool other) : this() {
      value_ = other.value_;
    }

    public Bool Clone() {
      return new Bool(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private bool value_;
    public bool Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Bool);
    }

    public bool Equals(Bool other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value != false) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != false) {
        output.WriteRawTag(8);
        output.WriteBool(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(Bool other) {
      if (other == null) {
        return;
      }
      if (other.Value != false) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Value = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Product : pb::IMessage<Product> {
    private static readonly pb::MessageParser<Product> _parser = new pb::MessageParser<Product>(() => new Product());
    public static pb::MessageParser<Product> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::WaiterServiceProto.WaiterServiceReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Product() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Product(Product other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      description_ = other.description_;
    }

    public Product Clone() {
      return new Product(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    public string Description {
      get { return description_; }
      set {
        description_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Product);
    }

    public bool Equals(Product other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      return size;
    }

    public void MergeFrom(Product other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Order : pb::IMessage<Order> {
    private static readonly pb::MessageParser<Order> _parser = new pb::MessageParser<Order>(() => new Order());
    public static pb::MessageParser<Order> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::WaiterServiceProto.WaiterServiceReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Order() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Order(Order other) : this() {
      id_ = other.id_;
      table_ = other.table_;
      Products = other.products_ != null ? other.Products.Clone() : null;
    }

    public Order Clone() {
      return new Order(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "table" field.</summary>
    public const int TableFieldNumber = 2;
    private int table_;
    public int Table {
      get { return table_; }
      set {
        table_ = value;
      }
    }

    /// <summary>Field number for the "products" field.</summary>
    public const int ProductsFieldNumber = 3;
    private global::WaiterServiceProto.productArr products_;
    public global::WaiterServiceProto.productArr Products {
      get { return products_; }
      set {
        products_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Order);
    }

    public bool Equals(Order other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Table != other.Table) return false;
      if (!object.Equals(Products, other.Products)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Table != 0) hash ^= Table.GetHashCode();
      if (products_ != null) hash ^= Products.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Table != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Table);
      }
      if (products_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Products);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Table != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Table);
      }
      if (products_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Products);
      }
      return size;
    }

    public void MergeFrom(Order other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Table != 0) {
        Table = other.Table;
      }
      if (other.products_ != null) {
        if (products_ == null) {
          products_ = new global::WaiterServiceProto.productArr();
        }
        Products.MergeFrom(other.Products);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            Table = input.ReadInt32();
            break;
          }
          case 26: {
            if (products_ == null) {
              products_ = new global::WaiterServiceProto.productArr();
            }
            input.ReadMessage(products_);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class productArr : pb::IMessage<productArr> {
    private static readonly pb::MessageParser<productArr> _parser = new pb::MessageParser<productArr>(() => new productArr());
    public static pb::MessageParser<productArr> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::WaiterServiceProto.WaiterServiceReflection.Descriptor.MessageTypes[5]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public productArr() {
      OnConstruction();
    }

    partial void OnConstruction();

    public productArr(productArr other) : this() {
      values_ = other.values_.Clone();
    }

    public productArr Clone() {
      return new productArr(this);
    }

    /// <summary>Field number for the "values" field.</summary>
    public const int ValuesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::WaiterServiceProto.Product> _repeated_values_codec
        = pb::FieldCodec.ForMessage(10, global::WaiterServiceProto.Product.Parser);
    private readonly pbc::RepeatedField<global::WaiterServiceProto.Product> values_ = new pbc::RepeatedField<global::WaiterServiceProto.Product>();
    public pbc::RepeatedField<global::WaiterServiceProto.Product> Values {
      get { return values_; }
    }

    public override bool Equals(object other) {
      return Equals(other as productArr);
    }

    public bool Equals(productArr other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!values_.Equals(other.values_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= values_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      values_.WriteTo(output, _repeated_values_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += values_.CalculateSize(_repeated_values_codec);
      return size;
    }

    public void MergeFrom(productArr other) {
      if (other == null) {
        return;
      }
      values_.Add(other.values_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            values_.AddEntriesFrom(input, _repeated_values_codec);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class orderArr : pb::IMessage<orderArr> {
    private static readonly pb::MessageParser<orderArr> _parser = new pb::MessageParser<orderArr>(() => new orderArr());
    public static pb::MessageParser<orderArr> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::WaiterServiceProto.WaiterServiceReflection.Descriptor.MessageTypes[6]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public orderArr() {
      OnConstruction();
    }

    partial void OnConstruction();

    public orderArr(orderArr other) : this() {
      values_ = other.values_.Clone();
    }

    public orderArr Clone() {
      return new orderArr(this);
    }

    /// <summary>Field number for the "values" field.</summary>
    public const int ValuesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::WaiterServiceProto.Order> _repeated_values_codec
        = pb::FieldCodec.ForMessage(10, global::WaiterServiceProto.Order.Parser);
    private readonly pbc::RepeatedField<global::WaiterServiceProto.Order> values_ = new pbc::RepeatedField<global::WaiterServiceProto.Order>();
    public pbc::RepeatedField<global::WaiterServiceProto.Order> Values {
      get { return values_; }
    }

    public override bool Equals(object other) {
      return Equals(other as orderArr);
    }

    public bool Equals(orderArr other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!values_.Equals(other.values_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= values_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      values_.WriteTo(output, _repeated_values_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += values_.CalculateSize(_repeated_values_codec);
      return size;
    }

    public void MergeFrom(orderArr other) {
      if (other == null) {
        return;
      }
      values_.Add(other.values_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            values_.AddEntriesFrom(input, _repeated_values_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code