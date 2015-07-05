/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
static void Main(string[] args)
{
        sa(31L);
    _1:
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _1;else goto _3;
    _3:
        gw(1L,0L,1L);
        gw(8L,0L,9999L);
        sp();
        sa(9L);
        sa(9L);
    _4:
        sa(gr(8L,0L));
        sa(9L);
    _5:
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _5;else goto _7;
    _7:
        sp();
        sa(sr());
    _8:
        sa(tm(sr(),10L));
        sa(sr());
        if(sp()!=0)goto _9;else goto _88;
    _9:
        sa(sr());
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _10;else goto _87;
    _10:
        sa(1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10L));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _11;else goto _8;
    _11:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _12:
        sa(tm(sr(),10L));
        sa(sr());
        if(sp()!=0)goto _13;else goto _86;
    _13:
        sa(sr());
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _14;else goto _84;
    _14:
        sa(1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10L));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _15;else goto _12;
    _15:
        sp();
        sa(sp()*sp());
        sa(sr());
    _16:
        sa(tm(sr(),10L));
        sa(sr());
        if(sp()!=0)goto _17;else goto _83;
    _17:
        sa(sr());
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _18;else goto _81;
    _18:
        sa(1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10L));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _19;else goto _16;
    _19:
        sp();
        sa(9L);
    _20:
        sa(sr());
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _20;else goto _22;
    _22:
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
        if(sp()!=0)goto _80;else goto _23;
    _23:
        sp();
    _24:
        sa(gr(8L,0L)-1L);
        if(gr(8L,0L)!=1001L)goto _79;else goto _25;
    _25:
        sp();
        sa(sp()-1L);
        if(sr()!=1L)goto _78;else goto _26;
    _26:
        sp();
        gw(8L,0L,999L);
        sa(99L);
        sa(99L);
    _27:
        sa(gr(8L,0L));
        sa(9L);
    _28:
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _28;else goto _30;
    _30:
        sp();
        sa(sr());
    _31:
        sa(tm(sr(),10L));
        sa(sr());
        if(sp()!=0)goto _32;else goto _77;
    _32:
        sa(sr());
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _33;else goto _76;
    _33:
        sa(1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10L));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _34;else goto _31;
    _34:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _35:
        sa(tm(sr(),10L));
        sa(sr());
        if(sp()!=0)goto _36;else goto _75;
    _36:
        sa(sr());
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _37;else goto _73;
    _37:
        sa(1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10L));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _38;else goto _35;
    _38:
        sp();
        sa(sp()*sp());
        sa(sr());
    _39:
        sa(tm(sr(),10L));
        sa(sr());
        if(sp()!=0)goto _40;else goto _72;
    _40:
        sa(sr());
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _41;else goto _70;
    _41:
        sa(1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(td(sp(),10L));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _42;else goto _39;
    _42:
        sp();
        sa(9L);
    _43:
        sa(sr());
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _43;else goto _45;
    _45:
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
        if(sp()!=0)goto _69;else goto _46;
    _46:
        sp();
    _47:
        sa(gr(8L,0L)-1L);
        if(gr(8L,0L)!=101L)goto _50;else goto _48;
    _48:
        sp();
        sa(sp()-1L);
        if(sr()!=10L)goto _49;else goto _51;
    _49:
        sa(999L);
    _50:
        gw(8L,0L,sp());
        sa(sr());
        goto _27;
    _51:
        gw(8L,0L,32L);
        gw(7L,0L,gr(8L,0L)-1L);
        sp();
    _52:
        sa(gr(gr(8L,0L),2L));
        if((gr(gr(8L,0L),2L))==0)goto _68;else goto _53;
    _53:
        sa(sp()-gr(gr(7L,0L),2L));
        if(sp()!=0)goto _54;else goto _67;
    _54:
        sa(gr(7L,0L));
        if(gr(7L,0L)!=1L)goto _66;else goto _55;
    _55:
        sp();
        sa(gr(8L,0L));
        if(gr(8L,0L)!=2L)goto _65;else goto _56;
    _56:
        sp();
        sa(0L);
        sa(31L);
    _57:
        sa(sr());
        sa(2L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        if(sp()!=0)goto _58;else goto _64;
    _58:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);
        sa(sr());
    _59:
        if(sp()!=0)goto _57;else goto _60;
    _60:
        sp();
    _61:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _63;else goto _62;
    _62:
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _63:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _61;
    _64:
        sp();
        sa(sp()-1L);
        sa(sr());
        goto _59;
    _65:
        sa(sp()-1L);
        gw(8L,0L,sp());
        gw(7L,0L,gr(8L,0L)-1L);
        goto _52;
    _66:
        sa(sp()-1L);
        gw(7L,0L,sp());
        goto _52;
    _67:
        gw(gr(7L,0L),2L,0L);
        goto _54;
    _68:
        sp();
        goto _54;
    _69:
        sa(gr(1L,0L));
        gw(1L,0L,gr(1L,0L)+1L);
        sa(2L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _47;
    _70:
        sp();
    _71:
        sp();
        sp();
        sa(0L);
        goto _46;
    _72:
        sp();
        goto _71;
    _73:
        sp();
    _74:
        sp();
        goto _71;
    _75:
        sp();
        goto _74;
    _76:
        sp();
        goto _74;
    _77:
        sp();
        goto _74;
    _78:
        gw(8L,0L,9999L);
        sa(sr());
        goto _4;
    _79:
        gw(8L,0L,sp());
        sa(sr());
        goto _4;
    _80:
        sa(gr(1L,0L));
        gw(1L,0L,gr(1L,0L)+1L);
        sa(2L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _24;
    _81:
        sp();
    _82:
        sp();
        sp();
        sa(0L);
        goto _23;
    _83:
        sp();
        goto _82;
    _84:
        sp();
    _85:
        sp();
        goto _82;
    _86:
        sp();
        goto _85;
    _87:
        sp();
        goto _85;
    _88:
        sp();
        goto _85;
}}