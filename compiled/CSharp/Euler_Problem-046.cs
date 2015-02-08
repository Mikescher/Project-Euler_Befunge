/* compiled with BefunCompile v1.0.4 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADt2k1Lw0AQBuC/st20l4S4k020zVAWL5716CGkRS0LoriI7qk/3lk/oNraFooo8j6wgelMs5uZ5taYJSotY9TF48Pt4vpJnT3fLR5VmeKru8W9ak7U"+
                                    "H5cBAAAAAAAAAAAAAAAAAAAAAAAA/AO/+V88Z3cUxNViii5GFagtPLW55UDjsvM0TiFPf/Kcn84Risp4qrqRXLjT53qqhvHbb75ZPV17GsIkU9E0HxnHLfliTH4+UEun"+
                                    "b7TNuaKgrWZLIW8o2JrCrj3eOJJSVR/LZVP2mLwtWLIsO/hRJxdTFV4rXWb9rHdVSvpykMXZesVASlK6K61h6o/G5Mg7TgeXjOMlm0bGY6wMZBoDTfJJnjOnNQlVFSpi"+
                                    "uc1ek5r12dxT7anZWN7v1YvXJ95d0rteOZmANS2FxkgwlIjzUpoQldOXupZwpRlBYier4EaaMX+/jVQP06fSQhnBWvOWm7Ye7jra3s+51ZaW919+zkqnV2nLvgfO40BT"+
                                    "9QKcPtfBiCwAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<200&&y<57)?g[y*200+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<200&&y<57)g[y*200+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _4;
    _0:
        if(sp()!=0)goto _6; else goto _7;
    _1:
        if(sp()!=0)goto _19; else goto _8;
    _2:
        if(sp()!=0)goto _11; else goto _21;
    _3:
        if(sp()!=0)goto _17; else goto _22;
    _4:
        gw(1,0,200);
        gw(2,0,50);
        gw(4,0,10000);
        gw(3,0,2);
        goto _5;
    _5:
        gw(0,1,32);
        gw(1,1,32);
        gw(8,0,1073741824);
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(1),88);
        sa((gr(3,0))+(gr(3,0)));
        sa((gr(4,0))>((gr(3,0))+(gr(3,0)))?1:0);
        goto _0;
    _6:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(gr(3,0));
        sa(sp()+sp());
        sa(sr());
        sa(gr(4,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _0;
    _7:
        sp();
        goto _8;
    _8:
        sa((gr(3,0))+(1));
        gw(3,0,(gr(3,0))+(1));
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(32);
        {long v0=sp();sa(sp()-v0);}
        goto _1;
    _9:
        gw(3,0,0);
        gw(5,0,3);
        goto _20;
    _10:
        sp();
        sa(3);
        sa((((3)-(gr(5,0)))!=0)?0:1);
        goto _2;
    _11:
        System.Console.Out.Write((long)(sp()));
        return;
    _12:
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(gr(5,0));
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _2;
    _13:
        sa(sr());
        sa(gr(5,0));
        gw(9,0,0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        gw(7,0,sp());
        sa(gr(8,0));
        sa((gr(8,0))>(gr(7,0))?1:0);
        goto _3;
    _14:
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(gr(5,0));
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _2;
    _15:
        sp();
        goto _20;
    _16:
        sa(sr());
        sa(gr(9,0));
        sa(sp()+sp());
        sa(gr(7,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        gw(7,0,sp());
        sa(sr());
        sa(2);
        sa(sp()*sp());
        sa(gr(9,0));
        sa(sp()+sp());
        gw(9,0,sp());
        gw(9,0,td(gr(9,0),2));
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        goto _22;
    _17:
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(gr(7,0));
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _3;
    _18:
        sa(79);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _20;
    _19:
        sa((gr(4,0))>(gr(3,0))?1:0);
        if(sp()!=0)goto _5; else goto _9;
    _20:
        sa((gr(5,0))+(2));
        gw(5,0,(gr(5,0))+(2));
        sa(sr());
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(32);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _18; else goto _10;
    _21:
        sa(sr());
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(32);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _12; else goto _13;
    _22:
        sa(sr());
        if(sp()!=0)goto _24; else goto _23;
    _23:
        sp();
        sa((gr(9,0))*(gr(9,0)));
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _14; else goto _15;
    _24:
        sa(sr());
        sa(gr(9,0));
        sa(sp()+sp());
        sa(gr(7,0));
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _16; else goto _25;
    _25:
        gw(9,0,td(gr(9,0),2));
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        if(sp()!=0)goto _24; else goto _23;
}}