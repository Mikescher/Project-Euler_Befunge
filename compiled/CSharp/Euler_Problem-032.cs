/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADVVsFuwyAM/RUK7ALKhrNGbVBk7UOi9NBVuXLilI8fISRNm5S1nbq074CMjeQn7Ae25CXAeyxNJAoWx9L0Xg3WpKXSxdI0IkBKKBICiW6WpvI77NIE"+
                                    "JnClFXR/oL7ELT2jgADvK24NnNQf7XENHm7/GLVlDS4Fgqo1SFAmNdF7wpwe9lTgVhm9VXWWyaH+qN3uTTeooV41CCUY5/jQq4ZgqWNREY36HG0KHDeZY1A7Z5ZlWyFE"+
                                    "wqodd1tIoo2IXFedxdlx7eDv+d6olQGueDh6pKv5y+RDxU8TTPiO1hujPEQHMlwpzJNVT+zkMFzIMMGiMi/UuUPk4lOCyNcXH8nn0hDSPV3nAuSnY/40GqLftNePOxdX"+
                                    "0BIamqVx9SQUdMDmS4JsWNmkiW7S0Dxu/XTmGtmWY+81We9Jetf3mMDwWRWk0XX6b+PKWIUsNFJXTGLZGbcRKv5ogn4mctL22sKNN9LaqdDZziC9vpBs2vfCK88d0am3"+
                                    "VBipwoOAkhWlZsVOvn89mHdg1bcXqpauuaLbkD+gJTv8AFvIfdyeDQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<166&&y<21)?g[y*166+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<166&&y<21)g[y*166+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        sa(31);
    _1:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        if(sp()!=0)goto _1;else goto _3;
    _3:
        gw(1,0,1);
        gw(8,0,9999);
        sp();
        sa(9);
        sa(9);
    _4:
        sa(gr(8,0));
        sa(9);
    _5:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        if(sp()!=0)goto _5;else goto _7;
    _7:
        sp();
        sa(sr());
    _8:
        sa(tm(sr(),10));
        sa(sr());

        if(sp()!=0)goto _9;else goto _75;
    _9:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _10;else goto _75;
    _10:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10));

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _11;else goto _8;
    _11:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _12:
        sa(tm(sr(),10));
        sa(sr());

        if(sp()!=0)goto _13;else goto _75;
    _13:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _14;else goto _75;
    _14:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10));

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _15;else goto _12;
    _15:
        sp();
        sa(sp()*sp());

        sa(sr());
    _16:
        sa(tm(sr(),10));
        sa(sr());

        if(sp()!=0)goto _17;else goto _73;
    _17:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _18;else goto _73;
    _18:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10));

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _19;else goto _16;
    _19:
        sp();
        sa(9);
    _20:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());
        if(sp()!=0)goto _20;else goto _22;
    _22:
        sp();
        sa(sp()+sp());

        t0=sp();
        sa(sp()+t0);

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()-9L);

        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _72;else goto _23;
    _23:
        t0=gr(8,0)-1;

        if(gr(8,0)!=1001)goto _71;else goto _24;
    _24:
        sa(sp()-1L);


        if(sr()!=1)goto _70;else goto _25;
    _25:
        sp();
        gw(8,0,999);
        sa(99);
        sa(99);
    _26:
        sa(gr(8,0));
        sa(9);
    _27:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        if(sp()!=0)goto _27;else goto _29;
    _29:
        sp();
        sa(sr());
    _30:
        sa(tm(sr(),10));
        sa(sr());

        if(sp()!=0)goto _31;else goto _69;
    _31:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _32;else goto _69;
    _32:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10));

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _33;else goto _30;
    _33:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _34:
        sa(tm(sr(),10));
        sa(sr());

        if(sp()!=0)goto _35;else goto _69;
    _35:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _36;else goto _69;
    _36:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10));

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _37;else goto _34;
    _37:
        sp();
        sa(sp()*sp());

        sa(sr());
    _38:
        sa(tm(sr(),10));
        sa(sr());

        if(sp()!=0)goto _39;else goto _67;
    _39:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _40;else goto _67;
    _40:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10));

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _41;else goto _38;
    _41:
        sp();
        sa(9);
    _42:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());
        if(sp()!=0)goto _42;else goto _44;
    _44:
        sp();
        sa(sp()+sp());

        t0=sp();
        sa(sp()+t0);

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()+sp());

        sa(sp()-9L);

        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _66;else goto _45;
    _45:
        sa(gr(8,0)-1);

        if(gr(8,0)!=101)goto _48;else goto _46;
    _46:
        sp();
        sa(sp()-1L);


        if(sr()!=10)goto _47;else goto _49;
    _47:
        sa(999);
    _48:
        gw(8,0,sp());
        sa(sr());
        goto _26;
    _49:
        gw(8,0,32);
        gw(7,0,gr(8,0)-1);
        sp();
    _50:
        t0=gr(gr(8,0),2);

        if((gr(gr(8,0),2))==0)goto _52;else goto _51;
    _51:
        t0-=gr(gr(7,0),2);

        if((t0)!=0)goto _52;else goto _65;
    _52:
        t0=gr(7,0);

        if(gr(7,0)!=1)goto _64;else goto _53;
    _53:
        t0=gr(8,0);

        if(gr(8,0)!=2)goto _63;else goto _54;
    _54:
        sa(0);
        sa(31);
    _55:
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());

        if(sp()!=0)goto _56;else goto _62;
    _56:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());
    _57:
        if(sp()!=0)goto _55;else goto _58;
    _58:
        sp();
    _59:
        sa(sp()+sp());

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _61;else goto _60;
    _60:
        sa(sp()+sp());

        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _61:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _59;
    _62:
        sp();
        sa(sp()-1L);

        sa(sr());
        goto _57;
    _63:
        t0--;
        gw(8,0,t0);
        gw(7,0,gr(8,0)-1);
        goto _50;
    _64:
        t0--;
        gw(7,0,t0);
        goto _50;
    _65:
        gw(gr(7,0),2,0);
        goto _52;
    _66:
        sa(gr(1,0));
        gw(1,0,gr(1,0)+1);
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _45;
    _67:
        sp();
        sp();
        sp();
        t0=0;
        goto _45;
    _69:
        sp();
        goto _67;
    _70:
        gw(8,0,9999);
        sa(sr());
        goto _4;
    _71:
        gw(8,0,t0);
        sa(sr());
        goto _4;
    _72:
        sa(gr(1,0));
        gw(1,0,gr(1,0)+1);
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _23;
    _73:
        sp();
        sp();
        sp();
        t0=0;
        goto _23;
    _75:
        sp();
        goto _73;
}
}
