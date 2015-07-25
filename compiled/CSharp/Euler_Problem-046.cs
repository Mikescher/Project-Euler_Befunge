/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
        long t0,t1,t2;
        gw(1,0,200);
        gw(2,0,50);
        gw(4,0,10000);
        gw(3,0,2);
    _1:
        gw(0,1,32);
        gw(1,1,32);
        gw(8,0,1073741824);
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88);
        sa(gr(3,0)+gr(3,0));
        sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
    _2:
        if(sp()!=0)goto _24;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3,0)+1);
        gw(3,0,gr(3,0)+1);
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+1L);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=t0-32;
        if((t0)!=0)goto _6;else goto _4;
    _6:
        if(gr(4,0)>gr(3,0))goto _1;else goto _7;
    _7:
        gw(3,0,0);
        gw(5,0,3);
    _8:
        sa(gr(5,0)+2);
        gw(5,0,gr(5,0)+2);
        sa(sr());
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+1L);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=t0-32;
        if((t0)!=0)goto _9;else goto _10;
    _9:
        sa(79);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _8;
    _10:
        sp();
        sa(3);
        sa((3-gr(5,0)!=0)?0:1);
    _11:
        if(sp()!=0)goto _23;else goto _12;
    _12:
        sa(sr());
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+1L);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=t0-32;
        t0=(t0!=0)?0:1;
        if((t0)!=0)goto _17;else goto _13;
    _13:
        sa(sr());
        t0=gr(5,0);
        gw(9,0,0);
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        sa(td(sp(),2));
        sa(sr());
        gw(7,0,sp());
        sa(gr(8,0));
        sa(gr(8,0)>gr(7,0)?1:0);
    _14:
        if(sp()!=0)goto _22;else goto _15;
    _15:
        sa(sr());
        if(sp()!=0)goto _19;else goto _16;
    _16:
        sp();
        sa(sp()-(gr(9,0)*gr(9,0)));
        if(sp()!=0)goto _17;else goto _18;
    _17:
        sa(sp()+1L);
        sa((sr()-gr(5,0)!=0)?0:1);
        goto _11;
    _18:
        sp();
        goto _8;
    _19:
        if((sr()+gr(9,0))<=gr(7,0))goto _21;else goto _20;
    _20:
        gw(9,0,td(gr(9,0),2));
        sa(td(sp(),4));
        sa(sr());
        if(sp()!=0)goto _19;else goto _16;
    _21:
        t0=sr()+gr(9,0);
        t1=gr(7,0);
        t2=t1-t0;
        gw(7,0,t2);
        t0=(sr()*2)+gr(9,0);
        gw(9,0,t0);
        gw(9,0,td(gr(9,0),2));
        sa(td(sp(),4));
        goto _15;
    _22:
        sa(td(sp(),4));
        sa(sr()>gr(7,0)?1:0);
        goto _14;
    _23:
        System.Console.Out.Write((long)(sp()));
        return;
    _24:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));
        sa(sp()+1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3,0));
        sa(sr()<gr(4,0)?1:0);
        goto _2;
}}