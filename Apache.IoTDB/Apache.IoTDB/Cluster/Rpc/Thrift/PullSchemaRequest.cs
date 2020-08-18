/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


namespace Apache.IoTDB.Cluster.Rpc.Thrift
{

  public partial class PullSchemaRequest : TBase
  {
    private Node _header;

    public List<string> PrefixPaths { get; set; }

    public Node Header
    {
      get
      {
        return _header;
      }
      set
      {
        __isset.header = true;
        this._header = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool header;
    }

    public PullSchemaRequest()
    {
    }

    public PullSchemaRequest(List<string> prefixPaths) : this()
    {
      this.PrefixPaths = prefixPaths;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_prefixPaths = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.List)
              {
                {
                  TList _list17 = await iprot.ReadListBeginAsync(cancellationToken);
                  PrefixPaths = new List<string>(_list17.Count);
                  for(int _i18 = 0; _i18 < _list17.Count; ++_i18)
                  {
                    string _elem19;
                    _elem19 = await iprot.ReadStringAsync(cancellationToken);
                    PrefixPaths.Add(_elem19);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_prefixPaths = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Header = new Node();
                await Header.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_prefixPaths)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("PullSchemaRequest");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "prefixPaths";
        field.Type = TType.List;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, PrefixPaths.Count), cancellationToken);
          foreach (string _iter20 in PrefixPaths)
          {
            await oprot.WriteStringAsync(_iter20, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (Header != null && __isset.header)
        {
          field.Name = "header";
          field.Type = TType.Struct;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Header.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as PullSchemaRequest;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return TCollections.Equals(PrefixPaths, other.PrefixPaths)
        && ((__isset.header == other.__isset.header) && ((!__isset.header) || (System.Object.Equals(Header, other.Header))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(PrefixPaths);
        if(__isset.header)
          hashcode = (hashcode * 397) + Header.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("PullSchemaRequest(");
      sb.Append(", PrefixPaths: ");
      sb.Append(PrefixPaths);
      if (Header != null && __isset.header)
      {
        sb.Append(", Header: ");
        sb.Append(Header== null ? "<null>" : Header.ToString());
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}