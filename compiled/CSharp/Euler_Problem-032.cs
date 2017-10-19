/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0;
        sa(31);
        sa(31);
    _1:
        if(sp()!=0)goto _2;else goto _3;
    _2:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        goto _1;
    _3:
        gw(1,0,1);
        gw(8,0,9999);
        sp();
        sa(9);
        sa(9);
    _4:
        sa(gr(8,0));
        sa(9);
        sa(9);
    _5:
        if(sp()!=0)goto _6;else goto _7;
    _6:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        goto _5;
    _7:
        sp();
        sa(sr());
    _8:
        sa(sr()%10);
        sa(sr());

        if(sp()!=0)goto _9;else goto _79;
    _9:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}

        if((t0)!=0)goto _79;else goto _10;
    _10:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()/10L);

        sa(sr());

        if(sp()!=0)goto _8;else goto _11;
    _11:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _12:
        sa(sr()%10);
        sa(sr());

        if(sp()!=0)goto _13;else goto _79;
    _13:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}

        if((t0)!=0)goto _79;else goto _14;
    _14:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()/10L);

        sa(sr());

        if(sp()!=0)goto _12;else goto _15;
    _15:
        sp();
        sa(sp()*sp());

        sa(sr());
    _16:
        sa(sr()%10);
        sa(sr());

        if(sp()!=0)goto _17;else goto _78;
    _17:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}

        if((t0)!=0)goto _78;else goto _18;
    _18:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()/10L);

        sa(sr());

        if(sp()!=0)goto _16;else goto _19;
    _19:
        sp();
        sa(9);
        sa(9);
    _20:
        if(sp()!=0)goto _21;else goto _22;
    _21:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());
        goto _20;
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
    _23:
        if((t0)!=0)goto _77;else goto _24;
    _24:
        sp();
    _25:
        t0=gr(8,0)-1;

        if(gr(8,0)!=1001)goto _76;else goto _26;
    _26:
        sa(sp()-1L);


        if(sr()!=1)goto _27;else goto _28;
    _27:
        gw(8,0,9999);
        sa(sr());
        goto _4;
    _28:
        gw(8,0,999);
        sp();
        sa(99);
        sa(99);
    _29:
        sa(gr(8,0));
        sa(9);
        sa(9);
    _30:
        if(sp()!=0)goto _31;else goto _32;
    _31:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        goto _30;
    _32:
        sp();
        sa(sr());
    _33:
        sa(sr()%10);
        sa(sr());

        if(sp()!=0)goto _34;else goto _75;
    _34:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}

        if((t0)!=0)goto _75;else goto _35;
    _35:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()/10L);

        sa(sr());

        if(sp()!=0)goto _33;else goto _36;
    _36:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _37:
        sa(sr()%10);
        sa(sr());

        if(sp()!=0)goto _38;else goto _75;
    _38:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}

        if((t0)!=0)goto _75;else goto _39;
    _39:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()/10L);

        sa(sr());

        if(sp()!=0)goto _37;else goto _40;
    _40:
        sp();
        sa(sp()*sp());

        sa(sr());
    _41:
        sa(sr()%10);
        sa(sr());

        if(sp()!=0)goto _42;else goto _74;
    _42:
        sa(sr());
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}

        if((t0)!=0)goto _74;else goto _43;
    _43:
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()/10L);

        sa(sr());

        if(sp()!=0)goto _41;else goto _44;
    _44:
        sp();
        sa(9);
        sa(9);
    _45:
        if(sp()!=0)goto _46;else goto _47;
    _46:
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());
        goto _45;
    _47:
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
    _48:
        if((t0)!=0)goto _73;else goto _49;
    _49:
        sp();
    _50:
        t0=gr(8,0)-1;

        if(gr(8,0)!=101)goto _72;else goto _51;
    _51:
        sa(sp()-1L);


        if(sr()!=10)goto _70;else goto _52;
    _52:
        gw(8,0,32);
        sp();
    _53:
        gw(7,0,gr(8,0)-1);
    _54:
        t0=gr(gr(8,0),2);

        if((gr(gr(8,0),2))==0)goto _56;else goto _55;
    _55:
        t0-=gr(gr(7,0),2);

        if((t0)!=0)goto _56;else goto _69;
    _56:
        t0=gr(7,0);

        if(gr(7,0)!=1)goto _68;else goto _57;
    _57:
        t0=gr(8,0);

        if(gr(8,0)!=2)goto _67;else goto _58;
    _58:
        sa(0);
        sa(31);
        sa(31);
    _59:
        if(sp()!=0)goto _60;else goto _63;
    _60:
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());

        if(sp()!=0)goto _61;else goto _62;
    _61:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());
        goto _59;
    _62:
        sp();
        sa(sp()-1L);

        sa(sr());
        goto _59;
    _63:
        sp();
    _64:
        sa(sp()+sp());

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _66;else goto _65;
    _65:
        sa(sp()+sp());

        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _66:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _64;
    _67:
        t0--;
        gw(8,0,t0);
        goto _53;
    _68:
        t0--;
        gw(7,0,t0);
        goto _54;
    _69:
        gw(gr(7,0),2,0);
        goto _56;
    _70:
        gw(8,0,999);
    _71:
        sa(sr());
        goto _29;
    _72:
        gw(8,0,t0);
        goto _71;
    _73:
        sa(gr(1,0));
        gw(1,0,gr(1,0)+1);
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _50;
    _74:
        sp();
        t0=0;
        sp();
        sp();
        sa(0);
        goto _48;
    _75:
        sp();
        goto _74;
    _76:
        gw(8,0,t0);
        sa(sr());
        goto _4;
    _77:
        sa(gr(1,0));
        gw(1,0,gr(1,0)+1);
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _25;
    _78:
        sp();
        t0=0;
        sp();
        sp();
        sa(0);
        goto _23;
    _79:
        sp();
        goto _78;
}
}
