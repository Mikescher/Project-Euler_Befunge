/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABAClks1yhCAMx18FcG8MFvxYjeMwfYO97qGj3rhy4rQPvwkq2g720GYGiJL880s0MPZktIpk7Moo8JEsF2HFIAKe4VKDsZGNIR4Y5o0EJbRwWoLX9aCM"+
                                    "07V4iDXOgsaX2ttaO5DaGTWsnscUNXR4+7W8YjFMm6eCpyIKRRyKO93F52K82aEIc6ddu/wCZ19BmZEk51DwBWXhlm0iqkUXJUHxXBCbWFRbJ/MUFCmNxxlhG0ZiM56a"+
                                    "mfA2qoHGJsHQVuEmZWv8SX1TszFCfAjFoE8e7F7Y1ACfcUqYn+93UwsKs3D8HbDNuyevB/pKGxsRQU1bs7E5xfmKJw+2eyJqktf+k61ORFXymjMblYpVYvlLtioRHRPU"+
                                    "f2Q77JOVZflz7WwRCDra+gwaqfUwZgt9N0sSsP8fu84JlsdO3+lgHQ7PAwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<39&&y<25)?g[y*39+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<39&&y<25)g[y*39+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(9L,0L,58L);
        gw(3L,0L,0L);
    _1:
        sa(gr(gr(3L,0L)+9L,0L)-1L);
        gw(gr(3L,0L)+9L,0L,gr(gr(3L,0L)+9L,0L)-1L);
        sa(sp()-48L);
        sa(sr());
        gw(7L,0L,sp());
        sa((sp()<0L)?1:0);
        if(sp()!=0)goto _2;else goto _3;
    _2:
        sa(79L);
        sa(gr(3L,0L)-1L);
        gw(3L,0L,gr(3L,0L)-1L);
        sa(sp()+9L);
        sa(0L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        sa(sp()+9L);
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _1;
    _3:
        if(gr(gr(7L,0L)+9L,1L)-79L==0)goto _4;else goto _1;
    _4:
        sa(gr(3L,0L));
        if((gr(3L,0L))!=0)goto _5;else goto _27;
    _5:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _6;else goto _26;
    _6:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _7;else goto _25;
    _7:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _8;else goto _24;
    _8:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _9;else goto _23;
    _9:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _10;else goto _22;
    _10:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _11;else goto _21;
    _11:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _12;else goto _20;
    _12:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _19;else goto _13;
    _13:
        sa((((gr(15L,0L)+gr(16L,0L)+gr(17L,0L))-gr(5L,1L)!=0)?1:0)+((gr(7L,0L)-9L!=0)?0:1));
    _14:
        if(sp()!=0)goto _18;else goto _15;
    _15:
        sp();
        if(9L<=gr(3L,0L))goto _16;else goto _17;
    _16:
        sa(gr(10L,0L)-47L);
        sa(gr(17L,0L)-47L);
        sa(gr(18L,0L)-47L);
        sa(gr(17L,0L)-47L);
        sa(gr(15L,0L)-47L);
        sa(gr(16L,0L)-47L);
        sa(gr(15L,0L)-47L);
        sa(gr(13L,0L)-47L);
        sa(gr(14L,0L)-47L);
        sa(gr(13L,0L)-47L);
        sa(gr(11L,0L)-47L);
        sa(gr(12L,0L)-47L);
        sa(gr(11L,0L)-47L);
        sa(gr(10L,0L)-47L);
        System.Console.Out.Write((long)(gr(9L,0L)-47L));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((long)(sp()));
        return;
    _17:
        gw(gr(7L,0L)+9L,1L,88L);
        sa(58L);
        sa(gr(3L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        sa(sp()+9L);
        sa(0L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _1;
    _18:
        sp();
        goto _1;
    _19:
        sa((((gr(17L,0L)+gr(18L,0L)+gr(10L,0L))-gr(5L,1L)!=0)?1:0)+((gr(9L,0L)-48L)>gr(7L,0L)?1:0));
        goto _14;
    _20:
        sa((gr(9L,0L)-48L)>gr(7L,0L)?1:0);
        goto _14;
    _21:
        sa((((gr(13L,0L)+gr(14L,0L)+gr(15L,0L))-gr(5L,1L)!=0)?1:0)+((gr(7L,0L)-9L!=0)?0:1));
        goto _14;
    _22:
        sa((gr(9L,0L)-48L)>gr(7L,0L)?1:0);
        goto _14;
    _23:
        sa((((gr(11L,0L)+gr(12L,0L)+gr(13L,0L))-gr(5L,1L)!=0)?1:0)+((gr(7L,0L)-9L!=0)?0:1));
        goto _14;
    _24:
        sa((gr(9L,0L)-48L)>gr(7L,0L)?1:0);
        goto _14;
    _25:
        gw(5L,1L,gr(9L,0L)+gr(10L,0L)+gr(11L,0L));
        sa((gr(7L,0L)-9L!=0)?0:1);
        goto _14;
    _26:
        sa((gr(7L,0L)-9L!=0)?0:1);
        goto _14;
    _27:
        sa(gr(7L,0L)>5L?1:0);
        goto _14;
}}