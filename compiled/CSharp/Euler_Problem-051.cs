/* compiled with BefunCompile v1.0.3 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACNVMuO6yAM/RUmJJsibsHNqwh55g/6A1E60l2wzYpV7r9fmzTNoxl1rKhKiX045hyT/c0MDGIXUaCBYJVz/BGKDxnvVfq9WBjQpm/0Bs1J86oBGCKK"+
                                    "KDcxo6Eco9SnNvuXBTCeVvLVXv1+cy/QSjMKcbvdRHputCqX/C9JkPM/yQVT2VH4/t5LbzGKY26/C4TUMXV50R89ULW1xhgrP1MsaPgbtH3HXlhjj9AYr49QiiGAVU2n"+
                                    "MpMVqqoClA6ld1MOC0CKTREUcSOsQzQGDFWlziWJuKM0agIPtI8T2voBSpKqZnKp0R/QlvoVwwDgHmJIlDla7RpFlokhCGHsrlNsIbR65OyvtwdX+9F1iajwGTDartPJ"+
                                    "WNhA+LM5ZcxfwTCXng7jRAeqopnQ1p3GAa7UywCtJeB7lOL7DAEqR44qOnrxIvJqASSEjwln+vGZJjRu9ZXbI9xCjYmSn3vJkl6KpCROYPGZkST9EQ1BVxA6mtD+XivX"+
                                    "u2aA6j7PBm9Ao+qWCUmSLmh4ZXtfaYYf31NfM1OmVQL7pqCTV11DmaFUQwkP1+0ma9R0bFfaDGu6RNhqVmi6LUKgclL6xf5ktjO7+nCCMeWnmpwTYp2v8tARlw2rHXpc"+
                                    "68ZibYTzOLmTSyNG8S7aDXQisBLOidmdSnhVvUUDov8ULu6FU2Tap6P692hIErbzVb71e8/Pyp/q+K5cx3+VQY0mGAYAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<78&&y<20)?g[y*78+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<78&&y<20)g[y*78+x]=v;}
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
        goto _24;
    _0:
        if(sp()!=0)goto _26; else goto _27;
    _1:
        if(sp()!=0)goto _22; else goto _28;
    _2:
        if(sp()!=0)goto _22; else goto _30;
    _3:
        if(sp()!=0)goto _64; else goto _32;
    _4:
        if(sp()!=0)goto _35; else goto _34;
    _5:
        if(sp()!=0)goto _36; else goto _37;
    _6:
        if(sp()!=0)goto _40; else goto _38;
    _7:
        if(sp()!=0)goto _41; else goto _38;
    _8:
        if(sp()!=0)goto _42; else goto _38;
    _9:
        if(sp()!=0)goto _43; else goto _62;
    _10:
        if(sp()!=0)goto _61; else goto _45;
    _11:
        if(sp()!=0)goto _47; else goto _48;
    _12:
        if(sp()!=0)goto _49; else goto _50;
    _13:
        if(sp()!=0)goto _55; else goto _51;
    _14:
        if(sp()!=0)goto _56; else goto _51;
    _15:
        if(sp()!=0)goto _57; else goto _51;
    _16:
        if(sp()!=0)goto _58; else goto _59;
    _17:
        if(sp()!=0)goto _54; else goto _52;
    _18:
        if(sp()!=0)goto _39; else goto _53;
    _19:
        if(sp()!=0)goto _29; else goto _31;
    _20:
        if(sp()!=0)goto _51; else goto _60;
    _21:
        if(sp()!=0)goto _38; else goto _63;
    _22:
        if(((gr(0,2))-(1000))!=0)goto _25;else goto _65;
    _23:
        if((((gr(0,gr(1,2)))-(48))+(gr(2,2)))!=0)goto _31;else goto _39;
    _24:
        gw(0,2,99);
        goto _22;
    _25:
        sa((gr(0,2))+(1));
        sa((gr(0,2))+(1));
        gw(0,2,(gr(0,2))+(1));
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        goto _0;
    _26:
        sp();
        goto _22;
    _27:
        sa(5);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        goto _1;
    _28:
        gw(1,2,3);
        goto _29;
    _29:
        sa((gr(1,2))+(1));
        gw(1,2,(gr(1,2))+(1));
        sa(14);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _2;
    _30:
        gw(2,2,0);
        goto _23;
    _31:
        gw(4,2,gr(0,2));
        sa(5);
        sa((gr(5,gr(1,2)))-(48));
        goto _3;
    _32:
        sa(sr());
        sa((gr(2,2))+(48));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(7);
        sa(sp()+sp());
        sa(gr(1,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _33;
    _33:
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _4;
    _34:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(gr(1,2));
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        goto _3;
    _35:
        sp();
        sa((gr(12,gr(1,2)))-(48));
        sa(5);
        sa(5);
        goto _5;
    _36:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(7);
        sa(sp()+sp());
        sa(gr(1,2));
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _5;
    _37:
        sp();
        sa(10);
        sa(sp()*sp());
        sa(sp()+sp());
        sa(10);
        sa(sp()*sp());
        sa(sp()+sp());
        sa(10);
        sa(sp()*sp());
        sa(sp()+sp());
        sa(10);
        sa(sp()*sp());
        sa(sp()+sp());
        sa(10);
        sa(sp()*sp());
        sa(sp()+sp());
        sa(sr());
        gw(7,2,sp());
        sa(sr());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _6;
    _38:
        sp();
        goto _39;
    _39:
        sa((gr(2,2))+(1));
        gw(2,2,(gr(2,2))+(1));
        sa(3);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _19;
    _40:
        sa(sr());
        sa(3);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _7;
    _41:
        gw(5,2,sp());
        sa(7);
        sa(tm(gr(5,2),7));
        goto _8;
    _42:
        sa(sr());
        sa(td(gr(5,2),2));
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _9;
    _43:
        gw(8,2,1);
        gw(9,2,gr(2,2));
        gw(9,2,(gr(9,2))+(1));
        gw(4,2,gr(0,2));
        sp();
        goto _44;
    _44:
        sa(5);
        sa((gr(5,gr(1,2)))-(48));
        goto _10;
    _45:
        sa(sr());
        sa((gr(9,2))+(48));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(7);
        sa(sp()+sp());
        sa((gr(9,2))+(4));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _46;
    _46:
        sa(sr());
        goto _11;
    _47:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(gr(1,2));
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        goto _10;
    _48:
        sp();
        sa((gr(12,(gr(9,2))+(4)))-(48));
        sa(5);
        sa(5);
        goto _12;
    _49:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(7);
        sa(sp()+sp());
        sa((gr(9,2))+(4));
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _12;
    _50:
        sp();
        sa(10);
        sa(sp()*sp());
        sa(sp()+sp());
        sa(10);
        sa(sp()*sp());
        sa(sp()+sp());
        sa(10);
        sa(sp()*sp());
        sa(sp()+sp());
        sa(10);
        sa(sp()*sp());
        sa(sp()+sp());
        sa(10);
        sa(sp()*sp());
        sa(sp()+sp());
        sa(sr());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _13;
    _51:
        sp();
        sa((gr(9,2))-(9));
        goto _17;
    _52:
        sa((gr(8,2))-(8));
        goto _18;
    _53:
        System.Console.Out.Write((long)(gr(7,2)));
        return;
    _54:
        gw(9,2,(gr(9,2))+(1));
        gw(4,2,gr(0,2));
        goto _44;
    _55:
        sa(sr());
        sa(3);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _14;
    _56:
        gw(5,2,sp());
        sa(7);
        sa(tm(gr(5,2),7));
        goto _15;
    _57:
        sa(sr());
        sa(td(gr(5,2),2));
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _16;
    _58:
        gw(8,2,(gr(8,2))+(1));
        goto _51;
    _59:
        sa(sr());
        sa(2);
        {long v0=sp();sa(sp()-v0);}
        sa(gr(5,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        goto _20;
    _60:
        sa(6);
        sa(sp()+sp());
        sa(sr());
        sa(gr(5,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _15;
    _61:
        sa(sr());
        sa((tm(gr(4,2),10))+(48));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(7);
        sa(sp()+sp());
        sa((gr(9,2))+(4));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(4,2,td(gr(4,2),10));
        goto _46;
    _62:
        sa(sr());
        sa(2);
        {long v0=sp();sa(sp()-v0);}
        sa(gr(5,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        goto _21;
    _63:
        sa(6);
        sa(sp()+sp());
        sa(sr());
        sa(gr(5,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _8;
    _64:
        sa(sr());
        sa((tm(gr(4,2),10))+(48));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(7);
        sa(sp()+sp());
        sa(gr(1,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(4,2,td(gr(4,2),10));
        goto _33;
    _65:
        return;
}}