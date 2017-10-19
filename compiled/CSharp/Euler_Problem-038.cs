/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADNkDtvxCAMgP8KSegSmivOY6iFrFs6V8qMckNVsTIx8eNrSKqQi3Tq1PYbjJ/4EZpvxP8mHAYNfz3OEbNez8M4GXG+aDGtAlPUHdYw57WMuCf43mrc"+
                                    "/RR2uXlkMoJ1PZ7LS6j+/KjbATz1IwsNHRAO4FqLI7iuWW6SLGjPAUs4TerJsnjBHADt2GgVxxFUcrHHJjXcZEomIaDDyG1yKUbC3lWRwPY+f1NFQTkvpVEq466s8yyQ"+
                                    "mg/Z4vHiwy1Wlh/k3GHL60iSuP0hm12umKA25OOL/iZSUn6pcGl67Sors7EIumTlmuVzQtTz+zy/1eYL/qbl3PYDAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<169&&y<6)?g[y*169+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<169&&y<6)g[y*169+x]=v;}
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        gw(3,1,9999);
        gw(4,1,2);
    _1:
        sa(-1);
        sa(gr(3,1));
        sa(1);
        sa(1-gr(4,1));
    _2:
        if(sp()!=0)goto _29;else goto _3;
    _3:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _4:
        gw(1,0,sp());
        sa(-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _5:
        sa(sr()%10);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/10L);

        sa(sr());
        if(sp()!=0)goto _5;else goto _7;
    _7:
        sp();
    _8:
        sa(sp()+(gr(1,0)*10));

        gw(1,0,sp());
        if(sr()!=-1)goto _8;else goto _10;
    _10:
        sp();
        sa(gr(1,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sr()!=-1)goto _4;else goto _11;
    _11:
        sp();
        sa(sr());
        sa(9);
        sa(9);
    _12:
        if(sp()!=0)goto _13;else goto _14;
    _13:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        goto _12;
    _14:
        sp();
        sa(sr());
    _15:
        sa(sr()%10);
        sa(sr());

        if(sp()!=0)goto _16;else goto _28;
    _16:
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}

        if(sp()!=0)goto _28;else goto _17;
    _17:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()/10L);

        sa(sr());

        if(sp()!=0)goto _15;else goto _18;
    _18:
        sp();
        sa(9);
        sa(9);
    _19:
        if(sp()!=0)goto _20;else goto _21;
    _20:
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());
        goto _19;
    _21:
        sp();
        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()-9L);

        sa((sp()!=0)?0:1);
    _22:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sp();

        if(sp()!=0)goto _27;else goto _23;
    _23:
        sp();
        sa(gr(4,1)-2);
        gw(4,1,gr(4,1)-1);

        if(sp()!=0)goto _1;else goto _24;
    _24:
        sa(gr(3,1)-1);
        gw(3,1,gr(3,1)-1);

        if(sp()!=0)goto _26;else goto _25;
    _25:
        System.Console.Out.Write("RORRE");
        return;
    _26:
        gw(4,1,5);
        goto _1;
    _27:
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _28:
        sp();
        sp();
        sa(0);
        goto _22;
    _29:
        sa(sp()+1L);

        sa(sr()*gr(3,1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr()-gr(4,1));
        goto _2;
}
}
