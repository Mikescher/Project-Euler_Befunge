/* compiled with BefunCompile v1.0.3 (c) 2015 */
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
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static readonly System.Random r = new System.Random();
private static bool rd(){ return r.Next(2)!=0; }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _12;
    _0:
        if(sp()!=0)goto _14; else goto _15;
    _1:
        if(sp()!=0)goto _17; else goto _18;
    _2:
        if(sp()!=0)goto _19; else goto _20;
    _3:
        if(sp()!=0)goto _16; else goto _21;
    _4:
        if(sp()!=0)goto _38; else goto _22;
    _5:
        if(sp()!=0)goto _24; else goto _37;
    _6:
        if(sp()!=0)goto _25; else goto _35;
    _7:
        if(sp()!=0)goto _26; else goto _23;
    _8:
        if(sp()!=0)goto _34; else goto _27;
    _9:
        if(sp()!=0)goto _29; else goto _30;
    _10:
        if(sp()!=0)goto _13; else goto _31;
    _11:
        if(sp()!=0)goto _32; else goto _33;
    _12:
        gw(3,1,9999);
        gw(4,1,2);
        goto _13;
    _13:
        sa(-1);
        sa((1)*(gr(3,1)));
        sa(1);
        sa((1)-(gr(4,1)));
        goto _0;
    _14:
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(gr(3,1));
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(gr(4,1));
        {long v0=sp();sa(sp()-v0);}
        goto _0;
    _15:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _16;
    _16:
        gw(1,0,sp());
        sa(-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _17;
    _17:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _1;
    _18:
        sp();
        goto _19;
    _19:
        sa((gr(1,0))*(10));
        sa(sp()+sp());
        gw(1,0,sp());
        sa(sr());
        sa(1);
        sa(sp()+sp());
        goto _2;
    _20:
        sp();
        sa(gr(1,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(1);
        sa(sp()+sp());
        goto _3;
    _21:
        sp();
        sa(sr());
        sa(9);
        sa(9);
        goto _4;
    _22:
        sp();
        sa(sr());
        goto _23;
    _23:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        goto _5;
    _24:
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        goto _6;
    _25:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _7;
    _26:
        sp();
        sa(9);
        sa(9);
        goto _8;
    _27:
        sp();
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(9);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _28;
    _28:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sp();
        goto _9;
    _29:
        System.Console.Out.Write((long)(sp()));
        return;
    _30:
        sp();
        sa((gr(4,1))-(1));
        gw(4,1,(gr(4,1))-(1));
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        goto _10;
    _31:
        sa((gr(3,1))-(1));
        gw(3,1,(gr(3,1))-(1));
        goto _11;
    _32:
        gw(4,1,5);
        goto _13;
    _33:
        sa(69);
        sa(82);
        sa(82);
        sa(79);
        System.Console.Out.Write((char)(82));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((char)(sp()));
        return;
    _34:
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _8;
    _35:
        sp();
        goto _36;
    _36:
        sp();
        sa(0);
        goto _28;
    _37:
        sp();
        goto _36;
    _38:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _4;
}}